using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banco.WebApi.Models;
using Banco.WebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Banco.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }
        // GET: api/Cliente
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> Get()
        {
            var clientes = await _clienteService.GetAsync();
            return clientes.ToList();
        }

        // GET: api/Cliente/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<Cliente>> Get(int id)
        {
            var cliente = await _clienteService.GetAsync(id);
            if (cliente == null)
                return NotFound();
            return cliente;
        }

        // POST: api/Cliente
        /// <summary>
        /// Crea un cliente.
        /// </summary>
        /// <remarks>
        /// Ejemplo de request:
        ///
        ///     POST /Cliente
        ///     {
        ///        "apellido": "Perez",
        ///        "nombre": "Juan",
        ///        "fechaNacimiento": "01/01/1990"
        ///     }
        ///
        /// </remarks>
        /// <param name="cliente"></param>
        /// <returns>Un nuevo cliente creado</returns>
        /// <response code="201">Devuelve el nuevo cliente creado</response>
        [HttpPost]
        [ProducesResponseType(typeof(Cliente), StatusCodes.Status201Created)]
        public async Task<ActionResult<Cliente>> Post([FromBody] Cliente cliente)
        {
            await _clienteService.AddAsync(cliente);
            return CreatedAtAction("Get", new { id = cliente.Id }, cliente);
        }

        // PUT: api/Cliente/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
                return BadRequest();
            await _clienteService.UpdateAsync(cliente);
            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        /// <summary>
        /// Elimina un cliente específico.
        /// </summary>
        /// <remarks>
        /// Ejemplo de request:
        ///
        ///     DELETE /Cliente
        ///     {
        ///        "id": "1"
        ///     }
        ///
        /// </remarks>
        /// <param name="id"></param>
        /// <response code="204">La operación fue exitosa pero no devuelve nada en el response</response>
        /// <response code="404">Si el cliente es null</response> 
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var cliente = await _clienteService.GetAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            await _clienteService.DeleteAsync(id);

            return NoContent();
        }


    }
}
