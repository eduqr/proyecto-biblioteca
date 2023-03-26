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
            
            systemLogin.menuAccess();
            menu.MenuInicio();
        }
    }
}
