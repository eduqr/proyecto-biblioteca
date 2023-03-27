using Microsoft.EntityFrameworkCore;
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
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-SKDQ0GI;Database=BibliotecaBD;Trusted_Connection=True;");
        }

        //public DbSet<Libros> Libros { get; set; }
    }
}
