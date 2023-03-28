using ProyectoBiblioteca.Clases.Funciones_Consola;
using ProyectoBiblioteca.Contenedor;
using ProyectoBiblioteca.Context;
using ProyectoBiblioteca.CRUD;
using ProyectoBiblioteca.Menus_biblioteca;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    public class SystemLogin
    {


        public void menuAccess()
        {
            CrudAdmin retorna = new CrudAdmin();
            Menu menu = new Menu();
            using (var _context = new ConexionBD())
            {

                Administrador admin = new Administrador();
                Console.WriteLine("Nombre de usuario: ");
                string usuario = Console.ReadLine();

                Console.WriteLine("Contraseña: ");
                string contraseña = Console.ReadLine();

                var adminq = _context.Administrador.FirstOrDefault(a => a.Usuario == usuario && a.Contraseña == contraseña);

                if (adminq != null)
                {
                    Console.WriteLine("Bienvenido, " + admin.Usuario);
                    menu.MenuInicio();
                }
                else
                {
                    Console.WriteLine("Nombre de usuario o contraseña incorrectos.");
                    retorna.retornalogin();


                }
            }
        }
    }

}
