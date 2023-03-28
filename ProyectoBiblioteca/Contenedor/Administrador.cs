using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Contenedor
{
    public class Administrador
    {
        [Key]
        public int id { get; set; }

        public string Usuario { get; set; }

        public string Contraseña { get; set; }
    }
}
