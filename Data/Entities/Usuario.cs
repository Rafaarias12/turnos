using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Required]
        public Perfil Perfiles { get; set; }
        public int PerfilId { get; set; }
        public bool Activo { get; set; }
    }
}
