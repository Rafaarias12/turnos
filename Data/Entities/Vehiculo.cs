using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Placa { get; set; }
        [Required]
        public string Remolque { get; set; }
        [Required]
        public Conductor Conductores { get; set; }
        public int ConductorId { get; set; }
        [Required]
        public Empresa Empresas { get; set; }
        public int EmpresaId { get; set; }
        [Required]
        public Carga Cargas { get; set; }
        public int CargaId { get; set; }
        public ICollection<Operacion_Vehiculo> Operacion_Vehiculos { get; set; }
    }
}
