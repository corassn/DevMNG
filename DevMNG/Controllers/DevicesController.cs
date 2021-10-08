using DevMNG.Entities;
using DevMNG.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevMNG.Controllers
{
    public class DevicesController : BaseApiController
    {
        private readonly DeviceRepository _deviceRepository;

        public DevicesController(DeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }

        //get all devices
        [HttpGet]
        public ActionResult<List<Device>> Get() =>
            _deviceRepository.Get();

        //get device by ID
        [HttpGet("{id:length(24)}", Name = "GetDevice")]
        public ActionResult<Device> Get(string id)
        {
            var device = _deviceRepository.Get(id);

            if (device == null)
            {
                return NotFound();
            }

            return device;
        }

        //CREATE new device
        [HttpPost]
        public ActionResult<Device> Create(Device device)
        {
            _deviceRepository.Create(device);

            return CreatedAtRoute("GetDevice", new { id = device.Id.ToString() }, device);
        }

        //UPDATE existing device
        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Device deviceIn)
        {
            var device = _deviceRepository.Get(id);

            if(device == null)
            {
                return NotFound();
            }

            _deviceRepository.Update(id, deviceIn);

            return NoContent();
        }

        //DELETE device
        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var device = _deviceRepository.Get(id);

            if (device == null)
            {
                return NotFound();
            }

            _deviceRepository.Remove(device.Id);

            return NoContent();
        }






    }
}
