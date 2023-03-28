using ProyectoBiblioteca.Clases;
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
    }
}
