using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartEquipment.Domain.Entities;

namespace SmartEquipment.Application.Interfaces.Repositories
{
    public interface IDeviceRepository
    {
        Device GetById(int id);
        List<Device> GetAll();
        void Update(Device device);
    }
}
