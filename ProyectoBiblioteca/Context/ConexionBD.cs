using Microsoft.EntityFrameworkCore;
using ProyectoBiblioteca.Contenedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Context
{
    internal class ConexionBD :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8SQGGRC\MSSQLSERVER03;Database=Biblioteca22BMBD;Trusted_Connection=True;");
        }

        public DbSet<Libros> Libros { get; set; }


        public DbSet<Administrador> Administrador { get; set;} 

        public DbSet<Prestamo> Prestamo { get; set; }

    }
}
