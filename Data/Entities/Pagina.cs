using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Pagina
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public Modulo Modulos { get; set; }
        public int ModuloId { get; set; }
        public ICollection<Permiso> Permisos { get; set; }
    }
}
