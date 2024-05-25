using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BE.Models;
using Swp391.Service;

namespace Swp391.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class storesDtos : ControllerBase
    {
        private StoreDtosService _service = new StoreDtosService();
        /// <summary>
        /// Phuơng thức GET của api/storeDtos => lấy all stores 
        /// </summary>
        [HttpGet]
        public IActionResult getAllStore()
        {
            return Ok(_service.getAllStore());
        }

        // [HttpPost]
        // public IActionResult createStoreController(Store store) {
        //     return Ok(store);
        // }
    }
}