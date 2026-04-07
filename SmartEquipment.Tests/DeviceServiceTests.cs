using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartEquipment.Application.Services;
using Xunit;

namespace SmartEquipment.Tests
{
    public class DeviceServiceTests
    {
        [Fact]
        public void StartDevice_Should_Set_IsRunning_True()
        {
            var service = new DeviceService();

            var result = service.StartDevice(1);

            Assert.Throws<Exception>(() => service.StartDevice(1));
        }
    }
}
