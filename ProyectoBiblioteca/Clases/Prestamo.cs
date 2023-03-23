using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    public class Prestamo
    {
        [Key]

        public int Id { get; set; }
        public string ISBM { get; set; }
        public DateTime FechaPrestamo { get; set; }

        public DateTime FechaRetorno { get; set; }

        public string Matricula { get; set; }
    }
}
