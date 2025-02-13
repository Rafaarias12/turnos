using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Perfil
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<Permiso> Permisos { get; set; }
    }
}
