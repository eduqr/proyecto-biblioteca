using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        public string Matricula { get; set; }

        public string Nombre { get; set; }

        public string Carrera { get; set; }

        public string Grupo { get; set; }

        public string Correo { get; set; }
    }
}
