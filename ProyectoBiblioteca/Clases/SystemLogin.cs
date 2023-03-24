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
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\tv0.1.1");
            
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

            ConsoleKeyInfo keyUser;
            while ((keyUser = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            {
                if (keyUser.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Remove(password.Length - 1);
                    Console.Write("\b \b"); // borra asterisco
                }
                else if (char.IsLetterOrDigit(keyUser.KeyChar))
                {
                    password += keyUser.KeyChar;
                    Console.Write("*");
                }
            }

            Console.WriteLine("\n\n\n\t\t\t\t\t  [Ingresar] ");
            Console.ReadKey(true);

            //Console.ResetColor();

            if(checkAccess(username, password))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n\t\t\t\t  =-=-= Acceso correcto =-=-=");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\t\t\t\t    [Ir a Panel de Control]");
                Console.ReadKey(true);
                Console.ResetColor();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\t\t\t  =-=-= Usuario o contraseña incorrectos =-=-=");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\t\t\t\t\t  [Reintentar] ");
                Console.ReadKey(true);
                Console.Clear();
                menuAccess();
            }
        }
    }
}
