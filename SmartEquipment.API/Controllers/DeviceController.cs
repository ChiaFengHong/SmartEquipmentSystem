using Microsoft.AspNetCore.Mvc;
using SmartEquipment.API.Controllers;
using SmartEquipment.Application.Interfaces;

namespace SmartEquipment.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceService _deviceService;

        public DeviceController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        [HttpPost("{id}/start")]
        public IActionResult Start(int id)
        {
            var result = _deviceService.StartDevice(id);
            return Ok(result);
        }

        [HttpPost("{id}/stop")]
        public IActionResult Stop(int id)
        {
            var result = _deviceService.StopDevice(id);
            return Ok(result);
        }

        [HttpGet("{id}/status")]
        public IActionResult Status(int id)
        {
            var result = _deviceService.GetStatus(id);
            return Ok(result);
        }
    }
}
