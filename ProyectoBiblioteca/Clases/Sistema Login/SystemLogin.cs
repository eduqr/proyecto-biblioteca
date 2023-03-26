using ProyectoBiblioteca.Clases.Funciones_Consola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    public class SystemLogin
    {
        string username { get; set; }
        string password { get; set; }

        public void menuAccess()
        {
            FuncionesConsola.EstablecerTituloConsola("Inicio de sesión");
            FuncionesConsola.MostrarVersion();

            DecoradorConsola.RecuadroTituloBiblioteca();
            DecoradorConsola.RecuadroInicioSesion();

            Console.SetCursorPosition(35, 11);  // Se coloca cursor después de Usuario:
            username = Console.ReadLine();            
            Console.SetCursorPosition(38, 13);  // Se coloca cursor después de Contraseña:
            password = convertPassword();

            DecoradorConsola.OpcionIngresar();
            FuncionesConsola.Continuar();

            if(checkAccess(username, password))
            {
                DecoradorConsola.MensajeAceptado();
                FuncionesConsola.Continuar();
            }
            else
            {
                DecoradorConsola.MensajeRechazado();
                FuncionesConsola.Continuar();
                menuAccess();
            }
        }

        public bool checkAccess(string usuario, string contra)
        {
            string[] users = new string[] { "encargado1", "practicante1", "1" };
            string[] passwords = new string[] { "CUN23", "up23qr", "1" };

            int index = Array.IndexOf(users, usuario);

            return (index >= 0 && passwords[index] == contra);
        }

        public string convertPassword()
        {
            ConsoleKeyInfo teclaUsuario;
            string contra = "";
            while ((teclaUsuario = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            {
                if (teclaUsuario.Key == ConsoleKey.Backspace && contra.Length > 0)
                {
                    contra = contra.Remove(contra.Length - 1);
                    Console.Write("\b \b"); // borra asterisco
                }
                else if (char.IsLetterOrDigit(teclaUsuario.KeyChar))
                {
                    contra += teclaUsuario.KeyChar;
                    Console.Write("*");
                }
            }
            return contra;
        }
    }
}
