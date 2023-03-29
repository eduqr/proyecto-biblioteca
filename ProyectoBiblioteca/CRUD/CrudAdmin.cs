using ProyectoBiblioteca.Clases;
using ProyectoBiblioteca.Contenedor;
using ProyectoBiblioteca.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.CRUD
{
    public class CrudAdmin
    {
        SystemLogin sistema = new SystemLogin();

        
        public void retornalogin()
        {
            sistema.menuAccess();
        }

        public static void CrearCredenciales()
        {
            Administrador admin = new Administrador();
            using (var _context = new ConexionBD())
            {
                var cantidadLogins = _context.Administrador.Count();
                if (cantidadLogins == 0)
                {
                    admin.Usuario = "admin";
                    admin.Contraseña = "admin";
                    _context.Administrador.Add(admin);
                    _context.SaveChanges();
                }
            }
        }
    }
}
