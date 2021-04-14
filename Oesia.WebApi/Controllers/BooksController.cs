using Microsoft.AspNetCore.Mvc;
using Oesia.Infrastructure.DTOs;
using Oesia.Service.Interfaces;
using Oesia.WebApi.Base;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Oesia.WebApi.Controllers
{

    public class BooksController : BaseController
    {
        #region Members Variables
        private readonly IBookService _service;
        #endregion

        #region Constructor
        public BooksController(IBookService service)
        {
            _service = service;
        }
        #endregion

        #region PublicMethods
        [HttpPost("Create")]
        public async Task<IActionResult> CreateBook([FromBody] BookDTO book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await _service.CreateBook(book))
                        return Ok(new { Response = "Libro creado con éxito" });
                    else
                        return BadRequest(new { Response = "Error al crear el libro" });

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
        public async Task<IActionResult> UpdateBook([FromBody] BookDTO book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await _service.UpdateBook(book))
                        return Ok(new { Response = "Libro actualizado con éxito" });
                    else
                        return BadRequest(new { Response = "Error al actualizar el libro" });

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
        public async Task<IActionResult> DeleteBook(int id)
        {
            try
            {
                if (id != default)
                {
                    if (await _service.DeleteBook(id))
                        return Ok(new { Response = "Libro eliminado con éxito" });
                    else
                        return BadRequest(new { Response = "Error al eliminar el autor" });
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
        public async Task<IActionResult> GetAllBooks()
        {
            try
            {
                var query = await _service.GetAllBooks();
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
        public async Task<IActionResult> GetByIdBook(int id)
        {
            try
            {
                if (id != default)
                {
                    var query = await _service.GetByIdBook(id);
                    if (query != null)
                        return Ok(query);
                    else
                        return NoContent();
                }
                else
                    return BadRequest(new { Response = "Datos de libro vacío" });
            }
            catch (Exception ex)
            {
                return Conflict(new { Response = $"Excepción: {ex.Message}" });
            }
        }
        #endregion

    }
}
