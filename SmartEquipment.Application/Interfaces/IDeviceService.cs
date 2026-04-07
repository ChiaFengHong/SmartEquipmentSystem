using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartEquipment.Domain.Entities;

namespace SmartEquipment.Application.Interfaces
{
    public interface IDeviceService
    {
        Device StartDevice(int id);
        Device StopDevice(int id);
        Device GetStatus(int id);
    }
}
