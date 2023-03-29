using ProyectoBiblioteca.Clases.Funciones_Consola;
using ProyectoBiblioteca.Contenedor;
using ProyectoBiblioteca.Context;
using ProyectoBiblioteca.CRUD;
using ProyectoBiblioteca.Menus_biblioteca;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    public class SystemLogin
    {


        public void menuAccess()
        {
            CrudAdmin.CrearCredenciales();
            FuncionesConsola.EstablecerTituloConsola("Inicio de sesión");
            FuncionesConsola.MostrarVersion();
            DecoradorConsola.RecuadroTituloBiblioteca();
            CrudAdmin retorna = new CrudAdmin();
            Menu menu = new Menu();
            using (var _context = new ConexionBD())
            {

                Administrador admin = new Administrador();
                
                DecoradorConsola.RecuadroInicioSesion();
                Console.SetCursorPosition(35, 11);
                string usuario = Console.ReadLine();
                
                Console.SetCursorPosition(38, 13);
                string contraseña = convertPassword();

                var adminq = _context.Administrador.FirstOrDefault(a => a.Usuario == usuario && a.Contraseña == contraseña);

                if (adminq != null)
                {
                    DecoradorConsola.OpcionIngresar();
                    FuncionesConsola.Continuar();
                    DecoradorConsola.MensajeAceptado();
                    FuncionesConsola.Continuar();
                    menu.MenuInicio();   
                }
                else
                {
                    DecoradorConsola.OpcionIngresar();
                    FuncionesConsola.Continuar();
                    DecoradorConsola.MensajeRechazado();
                    FuncionesConsola.Continuar();
                    retorna.retornalogin();


                }
            }
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
