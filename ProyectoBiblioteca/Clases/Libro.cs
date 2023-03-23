using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    public class Libro
    {
        [Key]

        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Editorial { get; set; }

        public int Existencias { get; set; }

        public int EnPrestamo { get; set; }
    }
}
