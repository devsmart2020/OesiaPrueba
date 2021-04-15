using Microsoft.AspNetCore.Mvc;
using Oesia.Service.Interfaces;
using Oesia.WebApi.Base;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Oesia.WebApi.Controllers
{

    public class CountriesController : BaseController
    {
        private readonly ICountryService _service;

        public CountriesController(ICountryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var query = await _service.GetAllCountries();
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
