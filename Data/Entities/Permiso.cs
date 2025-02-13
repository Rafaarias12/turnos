using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Permiso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Pagina Paginas { get; set; }
        public int PaginaId { get; set; }
        public Perfil Perfiles { get; set; }
        public int PerfilId { get; set; }
    }
}
