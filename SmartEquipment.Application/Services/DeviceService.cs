using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartEquipment.Application.Interfaces;
using SmartEquipment.Domain.Entities;

namespace SmartEquipment.Application.Services
{
    public class DeviceService : IDeviceService
    {
        private static List<Device> _devices = new()
    {
        new Device { Id = 1, Name = "Machine-A", IsRunning = false, Temperature = 25 }
    };

        public Device StartDevice(int id)
        {
            var device = _devices.First(d => d.Id == id);

            if (device.IsRunning)
                throw new Exception("Device already running");

            device.IsRunning = true;
            device.LastUpdated = DateTime.Now;

            return device;
        }

        public Device StopDevice(int id)
        {
            var device = _devices.First(d => d.Id == id);

            if (!device.IsRunning)
                throw new Exception("Device already stopped");

            device.IsRunning = false;
            device.LastUpdated = DateTime.Now;

            return device;
        }

        public Device GetStatus(int id)
        {
            return _devices.First(d => d.Id == id);
        }
    }
}
