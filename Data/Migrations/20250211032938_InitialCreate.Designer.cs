﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20250211032938_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Data.Entities.Carga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.ToTable("Carga", (string)null);
                });

            modelBuilder.Entity("Data.Entities.Conductor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Licencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Conductor", (string)null);
                });

            modelBuilder.Entity("Data.Entities.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreContacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empresa", (string)null);
                });

            modelBuilder.Entity("Data.Entities.Operacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nombre")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.ToTable("Operacion", (string)null);
                });

            modelBuilder.Entity("Data.Entities.Operacion_Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<int>("OperacionId")
                        .HasColumnType("int");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OperacionId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Operacion_Vehiculo", (string)null);
                });

            modelBuilder.Entity("Data.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo_peso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Producto", (string)null);
                });

            modelBuilder.Entity("Data.Entities.Ruta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OperacionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OperacionId");

                    b.ToTable("Ruta", (string)null);
                });

            modelBuilder.Entity("Data.Entities.Ruta_Turno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Interruptor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RutaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RutaId");

                    b.ToTable("Ruta_Turno", (string)null);
                });

            modelBuilder.Entity("Data.Entities.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CargaId")
                        .HasColumnType("int");

                    b.Property<int>("ConductorId")
                        .HasColumnType("int");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remolque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CargaId");

                    b.HasIndex("ConductorId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Vehiculo", (string)null);
                });

            modelBuilder.Entity("Data.Entities.Zona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DesCorta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.ToTable("Zona", (string)null);
                });

            modelBuilder.Entity("Data.Entities.Carga", b =>
                {
                    b.HasOne("Data.Entities.Producto", "Productos")
                        .WithMany("Cargas")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Data.Entities.Operacion", b =>
                {
                    b.HasOne("Data.Entities.Producto", "Producto")
                        .WithMany("Operaciones")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Data.Entities.Operacion_Vehiculo", b =>
                {
                    b.HasOne("Data.Entities.Operacion", "Operaciones")
                        .WithMany("Operacion_Vehiculos")
                        .HasForeignKey("OperacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Vehiculo", "Vehiculos")
                        .WithMany("Operacion_Vehiculos")
                        .HasForeignKey("VehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Operaciones");

                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("Data.Entities.Ruta", b =>
                {
                    b.HasOne("Data.Entities.Operacion", "Operaciones")
                        .WithMany("Rutas")
                        .HasForeignKey("OperacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Operaciones");
                });

            modelBuilder.Entity("Data.Entities.Ruta_Turno", b =>
                {
                    b.HasOne("Data.Entities.Ruta", "Rutas")
                        .WithMany("Ruta_Turnos")
                        .HasForeignKey("RutaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rutas");
                });

            modelBuilder.Entity("Data.Entities.Vehiculo", b =>
                {
                    b.HasOne("Data.Entities.Carga", "Cargas")
                        .WithMany()
                        .HasForeignKey("CargaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Conductor", "Conductores")
                        .WithMany("Vehiculos")
                        .HasForeignKey("ConductorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Empresa", "Empresas")
                        .WithMany("Vehiculos")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargas");

                    b.Navigation("Conductores");

                    b.Navigation("Empresas");
                });

            modelBuilder.Entity("Data.Entities.Zona", b =>
                {
                    b.HasOne("Data.Entities.Producto", "Producto")
                        .WithMany("Zonas")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Data.Entities.Conductor", b =>
                {
                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("Data.Entities.Empresa", b =>
                {
                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("Data.Entities.Operacion", b =>
                {
                    b.Navigation("Operacion_Vehiculos");

                    b.Navigation("Rutas");
                });

            modelBuilder.Entity("Data.Entities.Producto", b =>
                {
                    b.Navigation("Cargas");

                    b.Navigation("Operaciones");

                    b.Navigation("Zonas");
                });

            modelBuilder.Entity("Data.Entities.Ruta", b =>
                {
                    b.Navigation("Ruta_Turnos");
                });

            modelBuilder.Entity("Data.Entities.Vehiculo", b =>
                {
                    b.Navigation("Operacion_Vehiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
