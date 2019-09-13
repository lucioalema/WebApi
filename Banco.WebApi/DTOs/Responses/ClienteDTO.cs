using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco.WebApi.DTOs.Responses
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}
