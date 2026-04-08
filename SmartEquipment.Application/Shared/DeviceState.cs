using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartEquipment.Domain.Entities;

namespace SmartEquipment.Application.Shared
{
    public static class DeviceState
    {
        public static List<Device> Devices = new()
        {
            new Device
            {
                Id = 1,
                Name = "Machine-A",
                IsRunning = false,
                Temperature = 25,
                LastUpdated = DateTime.Now
            }
        };
    }
}
