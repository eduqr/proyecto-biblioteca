using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases.Funciones_Consola
{
    public class DecoradorConsola
    {
        public static void RecuadroTituloBiblioteca()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine();
            //Console.WriteLine("\t\t\t\t" + "+----------------------------+");
            //Console.WriteLine("\t\t\t\t" + "|                            |");
            //Console.WriteLine("\t\t\t\t" + "|        BiblioPolis         |");
            //Console.WriteLine("\t\t\t\t" + "|                            |");
            //Console.WriteLine("\t\t\t\t" + "+----------------------------+");

            TextoAnimado(2,("\n\t\t\t\t"  + "+----------------------------+"));
            TextoAnimado(2,("\n\t\t\t\t"  + "|                            |"));
            TextoAnimado(30,("\n\t\t\t\t" + "|        BiblioPolis         |"));
            TextoAnimado(2,("\n\t\t\t\t"  + "|                            |"));
            TextoAnimado(2,("\n\t\t\t\t"  + "+----------------------------+"));
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void RecuadroInicioSesion()
        {
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("\t\t\t" + "+--------------------------------------------+");
            Console.WriteLine("\t\t\t" + "|              Inicio de sesión              |");
            Console.WriteLine("\t\t\t" + "+--------------------------------------------+");
            Console.WriteLine("\t\t\t" + "| Usuario:                                   |");
            Console.WriteLine("\t\t\t" + "|                                            |");
            Console.WriteLine("\t\t\t" + "| Contraseña:                                |");
            Console.WriteLine("\t\t\t" + "+--------------------------------------------+");
            Console.ResetColor();
        }

        public static void OpcionIngresar()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t" + "  [Ingresar]");
            Console.ResetColor();
        }

        public static void MensajeAceptado()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t" + "=-=-=-= Acceso correcto =-=-=-=");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t" + "    [Ir a Panel de Control]");
            Console.ResetColor();
        }

        public static void MensajeRechazado()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine("\t\t\t" + "  =-=-= Usuario o contraseña incorrectos =-=-=");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t" + "  [Reintentar]");
            Console.ResetColor();
        }

        public static void RecuadroMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t" + "+--------------+");
            Console.WriteLine("\t\t\t\t" + "|     Menú     |");
            Console.WriteLine("\t\t\t\t" + "+--------------+");
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void RecuadroInventario(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t" + "+----------------------------+");
            Console.WriteLine("\t\t\t\t\t" + "|  INVENTARIO BIBLIOTECARIO  |");
            Console.WriteLine("\t\t\t\t\t" + "+----------------------------+");
            Console.WriteLine("\t\t\t\t\t" + $"     {cantidad} Libros registrados");
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void TextoAnimado(int velocidad, string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write(texto[i]);
                Thread.Sleep(velocidad);
            }
        }

        public static void PantallaCarga()
        {
            Console.WriteLine();
            TextoAnimado(60, ("\t\t\t\tCargando..."));
            string[] secuencia = new string[] { "/", "─", "\\", "|" };
            int index = 0;
            int time = 15;
            while (time > 0)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"\r\t\t\t\t\t\t[{secuencia[index]}]");
                Thread.Sleep(70);
                index++;
                if (index == secuencia.Length) { index = 0; }
                time--;
            }
            Console.ResetColor();
            Console.Clear();
        }

        // NO TOCAR ESTA FUNCIÓN DE ABAJO
        // NO TOCAR ESTA FUNCIÓN DE ABAJO
        // NO TOCAR ESTA FUNCIÓN DE ABAJO
        // NO TOCAR ESTA FUNCIÓN DE ABAJO
        // NO TOCAR ESTA FUNCIÓN DE ABAJO
        // NO TOCAR ESTA FUNCIÓN DE ABAJO
        public static void Dibujar(int num)
        {
            switch (num)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Green;
                    string dibujoASCII = @"
                                         _.-""\
                                     _.-""     \
                                  ,-""          \
                                 ( \            \
                                  \ \            \
                                   \ \            \
                                    \ \         _.-;
                                     \ \    _.-""   :
                                      \ \,-""    _.-""
                                       \(   _.-"" 
                                       `--""";
                    Console.WriteLine(dibujoASCII);
                    Console.ResetColor();
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    dibujoASCII = @"
                               .--.                   .---.
                           .---|__|           .-.     |~~~|
                        .--|===|--|_          |_|     |~~~|--.
                        |  |===|  |'\     .---!~|  .--|   |--|
                        |%%|   |  |.'\    |===| |--|%%|   |  |
                        |%%|   |  |\.'\   |   | |__|  |   |  |
                        |  |   |  | \  \  |===| |==|  |   |  |
                        |  |   |__|  \.'\ |   |_|__|  |~~~|__|
                        |  |===|--|   \.'\|===|~|--|%%|~~~|--|
                        ^--^---'--^    `-'`---^-^--^--^---'--'";
                    Console.WriteLine(dibujoASCII);
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    dibujoASCII = @"
                                                   .oMc
                                                .MMMMMP
                                              .MM888MM
                        ....                .MM88888MP
                        MMMMMMMMb.         d8MM8tt8MM
                         MM88888MMMMc `:' dMME8ttt8MM
                          MM88tt888EMMc:dMM8E88tt88MP
                           MM8ttt888EEM8MMEEE8E888MC
                           `MM888t8EEEM8MMEEE8t8888Mb
                            ""MM88888tEM8""MME88ttt88MM
                             dM88ttt8EM8""MMM888ttt8MM
                             MM8ttt88MM"" "" ""MMNICKMM""
                             3M88888MM""      ""MMMP""
                              ""MNICKM""";
                    Console.WriteLine(dibujoASCII);
                    Console.ResetColor();
                    break;
                default:
                    break;
            }
        }
    }
}
