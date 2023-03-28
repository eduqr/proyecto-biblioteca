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
            Administrador admin = new Administrador();
            using (var _context = new ConexionBD()) 
            {
                admin.Usuario = "admin";
                admin.Contraseña = "admin";
                _context.Administrador.Add(admin);
                _context.SaveChanges();
            }
            sistema.menuAccess();
        }
    }
}
