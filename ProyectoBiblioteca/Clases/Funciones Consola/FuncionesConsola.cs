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
            
            Console.WriteLine("\t" + "Presione 'Enter' para continuar");
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
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tHasta luego!");
            Console.WriteLine();
            string despedida = @"
                                                   .oMc
                                                .MMMMMP
                                              .MM888MM
                        ....                .MM88888MP
                        MMMMMMMMb.         d8MM8tt8MM
                         MM88888MMMMc `:' dMME8ttt8MM
                          MM88tt888EMMc:dMM8E88tt88MP
                           MM8ttt888EEM8MMEEE8E888MC
                           `MM888t8EEEM8MMEEE8t8888Mb
                            """"MM88888tEM8""""MME88ttt88MM
                             dM88ttt8EM8""""MMM888ttt8MM
                             MM8ttt88MM"""" """" """"MMNICKMM""""
                             3M88888MM""""      """"MMMP""""
                              """"MNICKM""""
            ";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(despedida);
            Console.ResetColor();
        }

    }
}
