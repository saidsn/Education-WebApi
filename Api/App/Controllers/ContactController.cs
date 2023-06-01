using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class ContactController : AppController
    {

        private readonly IContactService _service;

        public ContactController(IContactService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IActionResult> Get([Required] int id)
        {
            try
            {
                return Ok(await _service.GetAsync(id));
            }
            catch (NullReferenceException)
            {

                return NotFound();
            }
        }
    }
}
