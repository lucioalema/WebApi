using System;
using System.ComponentModel.DataAnnotations;

namespace Banco.WebApi.DTOs.Requests
{
    public class ClienteAddDTO
    {
        [Required]
        [StringLength(60)]

        public string Apellido { get; set; }
        [Required]
        [StringLength(60)]
        public string Nombre { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaNacimiento { get; set; }
    }
}
