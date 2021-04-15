using Microsoft.AspNetCore.Mvc;
using Oesia.Service.Interfaces;
using Oesia.WebApi.Base;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Oesia.WebApi.Controllers
{

    public class StatesController : BaseController
    {
        private readonly IStateService _service;

        public StatesController(IStateService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var query = await _service.GetAllStates();
                if (query.Any())
                    return Ok(query);
                else
                    return NoContent();

            }
            catch (Exception ex)
            {
                return Conflict(new { Response = $"Excepción: {ex.Message}" });
            }
        }
    }
}
