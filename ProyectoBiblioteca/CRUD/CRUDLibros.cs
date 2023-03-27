using ProyectoBiblioteca.Contenedor;
using ProyectoBiblioteca.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoBiblioteca.CRUD
{
    internal class CRUDLibros
    {
        public void RegistrarLibro()
        {
            using (var _context = new ConexionBD())
            {
                Libros libros = new Libros();
            }
        }

        public void MostrarInventario()
        {

        }

        public void EditarLibro()
        {
            // no hacer este
        }

        public void EliminarRegistroLibro()
        {

        }
    }
}
