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
            Console.WriteLine();
            Console.WriteLine("\t\t" + "Presione 'Enter' para continuar");
            Console.ReadKey(true);
            Console.ResetColor();
            Console.Clear();
        }

        public static void EstablecerTituloConsola(string titulo)
        {
            Console.Title = "BiblioPlus : " + titulo;
        }

        public static void MostrarVersion()
        {
            const string version = "v0.1.8";
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + version);
            Console.ResetColor();
        }

        public static void Salir()
        {
            Console.WriteLine();
            Console.WriteLine("\tHasta luego!");
        }

    }
}
