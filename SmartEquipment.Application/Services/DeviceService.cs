using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartEquipment.Application.Interfaces;
using SmartEquipment.Application.Interfaces.Repositories;
using SmartEquipment.Domain.Entities;

namespace SmartEquipment.Application.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository _repository;

        public DeviceService(IDeviceRepository repository)
        {
            _repository = repository;
        }

        public Device StartDevice(int id)
        {
            var device = _repository.GetById(id);

            if (device.IsRunning)
                throw new Exception("Device already running");

            device.IsRunning = true;
            device.LastUpdated = DateTime.Now;

            _repository.Update(device);

            return device;
        }

        public Device StopDevice(int id)
        {
            var device = _repository.GetById(id);

            if (!device.IsRunning)
                throw new Exception("Device already stopped");

            device.IsRunning = false;
            device.LastUpdated = DateTime.Now;

            _repository.Update(device);

            return device;
        }

        public Device GetStatus(int id)
        {
            return _repository.GetById(id);
        }
    }
}
