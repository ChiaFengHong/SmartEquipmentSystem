using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartEquipment.Application.Interfaces.Repositories;
using SmartEquipment.Application.Shared;
using SmartEquipment.Domain.Entities;

namespace SmartEquipment.Infrastructure.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        public Device GetById(int id)
        {
            return DeviceState.Devices.First(d => d.Id == id);
        }

        public List<Device> GetAll()
        {
            return DeviceState.Devices;
        }

        public void Update(Device device)
        {
            // 模擬設備，不需要寫 DB
        }
    }
}
