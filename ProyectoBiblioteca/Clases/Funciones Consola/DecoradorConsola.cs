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

            TextoAnimado(1,("\n\t\t\t\t"  + "+----------------------------+"));
            TextoAnimado(1,("\n\t\t\t\t"  + "|                            |"));
            TextoAnimado(30,("\n\t\t\t\t" + "|        BiblioPolis         |"));
            TextoAnimado(1,("\n\t\t\t\t"  + "|                            |"));
            TextoAnimado(1,("\n\t\t\t\t"  + "+----------------------------+"));
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

        public static void OpcionRegresarMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("\t" + "[Ir al Menú]");
            Console.ResetColor();
        }

        public static void MensajeAceptado()
        {
            FuncionesConsola.EstablecerTituloConsola("Verificación exitosa");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("\t" + "Acceso verificado.");
            Console.WriteLine("\t" + "Bienvenido de vuelta.");

            OpcionRegresarMenu();
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine();
            //Console.WriteLine("\t" + "[Ir al Menú]");
            //Console.ResetColor();
        }

        public static void MensajeRechazado()
        {
            FuncionesConsola.EstablecerTituloConsola("Acceso no autorizado");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine("\t" + "Usuario o contraseña incorrectos.");
            Console.WriteLine("\t" + "Verifique sus credenciales.");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("\t" + "[Reintentar]");
            Console.ResetColor();
        }

        public static void RecuadroMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
        
        public static void RecuadroPrestamos(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t" + "+----------------------------+");
            Console.WriteLine("\t\t\t\t\t" + "|    PRÉSTAMOS BIBLIOTECA    |");
            Console.WriteLine("\t\t\t\t\t" + "+----------------------------+");
            Console.WriteLine("\t\t\t\t\t" + $"   {cantidad} préstamos registrados");
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
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    string dibujoASCII = @"
                         __...--~~~~~-._   _.-~~~~~--...__
                       //               `V'               \\ 
                      //                 |                 \\ 
                     //__...--~~~~~~-._  |  _.-~~~~~~--...__\\ 
                    //__.....----~~~~._\ | /_.~~~~----.....__\\
                   ====================\\|//====================
                                       `---` ";
                    Console.WriteLine(dibujoASCII);
                    Console.ResetColor();
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
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
                        
                       (\ 
                       \'\ 
                        \'\     __________  
                        / '|   ()_________)
                        \ '/    \ ~~~~~~~~ \
                         \       \ ~~~~~~   \
                        ==).      \__________\
                       (__)       ()__________)";
                    Console.WriteLine(dibujoASCII);
                    Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    dibujoASCII = @"
                                  _ _
                             .-. | | |
                             |M|_|A|N|
                             |A|a|.|.|<\
                             |T|r| | | \\
                             |H|t|M|Z|  \\      ""BiblioPolis"" 
                             | |!| | |   \>     
                        ";
                    Console.WriteLine(dibujoASCII);
                    Console.ResetColor();
                    break;
                default:
                    break;
            }
        }
    }
}
