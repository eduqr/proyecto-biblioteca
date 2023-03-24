using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    public class SystemLogin
    {
        public bool checkAccess(string usuario, string contra)
        {
            string[] users = new string[] {"encargado1", "practicante1"};
            string[] passwords = new string[] {"1234", "up23qr"};
            
            int index = Array.IndexOf(users, usuario);

            // SIMPLIFICAR ESTO
            if (index >= 0 && passwords[index] == contra)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void menuAccess()
        {
            FuncionesConsola.Titulo("Inicio de sesión");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\tv0.1.2");
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\t\t\t\t +----------------------------+");
            Console.WriteLine("\t\t\t\t |                            |");
            Console.WriteLine("\t\t\t\t |        BiblioPolis         |");
            Console.WriteLine("\t\t\t\t |                            |");
            Console.WriteLine("\t\t\t\t +----------------------------+");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\t\t\t+---------------------------------------------+");
            Console.WriteLine("\t\t\t|               Inicio de sesión              |");
            Console.WriteLine("\t\t\t+---------------------------------------------+");
            Console.WriteLine("\t\t\t| Usuario:                                    |");
            Console.WriteLine("\t\t\t|                                             |");
            Console.WriteLine("\t\t\t| Contraseña:                                 |");
            Console.WriteLine("\t\t\t+---------------------------------------------+");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(35, 11);
            string username = Console.ReadLine();
            
            Console.SetCursorPosition(38, 13);
            string password = "";
            
            password = convertPassword(password);

            Console.WriteLine("\n\n\n\t\t\t\t\t   [Ingresar] ");
            FuncionesConsola.Continuar();

            if(checkAccess(username, password))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n\t\t\t\t=-=-= Acceso correcto =-=-=");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\t\t\t\t  [Ir a Panel de Control]");
                FuncionesConsola.Continuar();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\t\t\t  =-=-= Usuario o contraseña incorrectos =-=-=");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\t\t\t\t\t  [Reintentar] ");
                FuncionesConsola.Continuar();
                Console.Clear();
                menuAccess();
            }
        }

        public string convertPassword(string contra)
        {
            ConsoleKeyInfo keyUser;
            while ((keyUser = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            {
                if (keyUser.Key == ConsoleKey.Backspace && contra.Length > 0)
                {
                    contra = contra.Remove(contra.Length - 1);
                    Console.Write("\b \b"); // borra asterisco
                }
                else if (char.IsLetterOrDigit(keyUser.KeyChar))
                {
                    contra += keyUser.KeyChar;
                    Console.Write("*");
                }
            }
            return contra;
        }
    }
}
