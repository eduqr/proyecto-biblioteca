using ProyectoBiblioteca.Clases;
using ProyectoBiblioteca.ClasesTemp;
using System;

namespace ProyectoBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            SystemLogin systemLogin = new SystemLogin();
            //menu.MenuInicio();
            systemLogin.menuAccess();
            menu.MenuInicio();

            // Proximo hacer menuAccess booleana
            /*
            if(systemLogin.menuAccess() )
            {
                menu.MenuInicio();
            }
            */
        }
    }
}
