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
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-HM7A63KQ;Database=BibliotecaBD;Trusted_Connection=True;");
        }

        public DbSet<Libros> Libros { get; set; }

        public DbSet<Administrador> Administrador { get; set;} 
    }
}
