using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    public class FuncionesConsola
    {
        public static void Continuar()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t\t\tPresione 'Enter' para continuar");
            Console.ReadKey(true);
            Console.ResetColor();
        }

        public static void Titulo(string titulo)
        {
            Console.Title = "BiblioPlus : " + titulo;
        }
    }
}
