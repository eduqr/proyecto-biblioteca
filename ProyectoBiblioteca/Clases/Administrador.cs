using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    public class Administrador
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int Pin { get; set; }


    }
}
