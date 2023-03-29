using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Contenedor
{
    public class Libros
    {
        [Key] public int Id { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int Unidades { get; set; }

    }
}
