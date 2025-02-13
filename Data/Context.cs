using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
namespace Data
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options): base(options)
        {
        }

        public DbSet<Carga> Cargas { get; set; }
        public DbSet<Conductor> Conductores { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Operacion> Operaciones { get; set; }
        public DbSet<Operacion_Vehiculo> Operacion_Vehiculos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Ruta> Rutas { get; set; }
        public DbSet<Ruta_Turno> Ruta_Turnos { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Zona> Zonas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Perfil> Perfiles { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Pagina> Paginas { get; set; }
        public DbSet<Modulo> Modulos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carga>().ToTable("Carga");
            modelBuilder.Entity<Conductor>().ToTable("Conductor");
            modelBuilder.Entity<Empresa>().ToTable("Empresa");
            modelBuilder.Entity<Operacion>().ToTable("Operacion");
            modelBuilder.Entity<Operacion_Vehiculo>().ToTable("Operacion_Vehiculo");
            modelBuilder.Entity<Producto>().ToTable("Producto");
            modelBuilder.Entity<Ruta>().ToTable("Ruta");
            modelBuilder.Entity<Ruta_Turno>().ToTable("Ruta_Turno");
            modelBuilder.Entity<Vehiculo>().ToTable("Vehiculo");
            modelBuilder.Entity<Zona>().ToTable("Zona");

            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Perfil>().ToTable("Perfil");
            modelBuilder.Entity<Permiso>().ToTable("Permiso");
            modelBuilder.Entity<Pagina>().ToTable("Pagina");
            modelBuilder.Entity<Modulo>().ToTable("Modulo");
        }

    }
}
