using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Context
{
    public class ConexionBD : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder opcionsBuilder)
        {
            opcionsBuilder.UseSqlServer(@"Server=DESKTOP; Database=LibreriaVargas; Trusted_Connection= True;");
        }



        public DbSet<Administrador> Administradores { get; set; }

        public DbSet<Libro> Libros { get; set; }

        public DbSet<Prestamo> Prestamos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
}
