using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Contenedor
{
    public class Prestamo
    {
        [Key] 
        public int Id { get; set; }
        
        public string Alumno { get; set; }

        public string Matricula { get; set; }

        public string Correo { get; set; }

        public string TituloLibroPrestado { get; set; }

        public DateTime FechaPedido { get; set; }

        public DateTime FechaRegreso { get; set; }

    }
}
