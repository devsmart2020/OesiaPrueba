using Microsoft.AspNetCore.Mvc;
using Oesia.Infrastructure.DTOs;
using Oesia.Service.Interfaces;
using Oesia.WebApi.Base;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Oesia.WebApi.Controllers
{
    public class AuthorsController : BaseController
    {
        #region Members Variables
        private readonly IAuthorService _service;
        #endregion

        #region Constructor
        public AuthorsController(IAuthorService service)
        {
            _service = service;
        }
        #endregion

        #region PublicMethods
        [HttpPost("Create")]
        public async Task<IActionResult> CreateAuthor([FromBody] AuthorDTO author)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await _service.CreateAuthor(author))
                        return Ok(new { Response = "Autor creado con éxito" });
                    else
                        return BadRequest(new { Response = "Error al crear el autor" });

                }
                else
                    return BadRequest(new { Response = "Estructura no válida" });
            }
            catch (Exception ex)
            {
                return Conflict(new { Response = $"Excepción: {ex.Message}" });
            }

        }

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAuthor([FromBody] AuthorDTO author)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await _service.UpdateAuthor(author))
                        return Ok(new { Response = "Autor actualizado con éxito" });
                    else
                        return BadRequest(new { Response = "Error al actualizar el autor" });

                }
                else
                    return BadRequest(new { Response = "Estructura no válida" });
            }
            catch (Exception ex)
            {
                return Conflict(new { Response = $"Excepción: {ex.Message}" });
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            try
            {
                if (id != default)
                {
                    var author = await _service.GetByIdAuthor(id);
                    if (author.NumberBooks == 0 || author.NumberBooks == default)
                    {

                        if (await _service.DeleteAuthor(id))
                            return Ok(new { Response = "Autor eliminado con éxito" });
                        else
                            return BadRequest(new { Response = "Error al eliminar el autor" });
                    }
                    else                    
                        return BadRequest(new { Response = "El autor tiene libros asociados" });

                    

                }
                else
                    return BadRequest(new { Response = "Estructura no válida" });
            }
            catch (Exception ex)
            {
                return Conflict(new { Response = $"Excepción: {ex.Message}" });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAuthors()
        {
            try
            {
                var query = await _service.GetAllAuthors();
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

        [HttpPost("GetById/{id:int}")]
        public async Task<IActionResult> GetByIdAuthor(int id)
        {
            try
            {
                if (id != default)
                {
                    var query = await _service.GetByIdAuthor(id);
                    if (query != null)
                        return Ok(query);
                    else
                        return NoContent();
                }
                else
                    return BadRequest(new { Response = "Datos de autor vacío" });
            }
            catch (Exception ex)
            {
                return Conflict(new { Response = $"Excepción: {ex.Message}" });
            }
        }
        #endregion
    }
}
