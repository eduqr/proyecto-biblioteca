using ProyectoBiblioteca.Clases.Funciones_Consola;
using ProyectoBiblioteca.Clases.Menus_biblioteca;
using ProyectoBiblioteca.Clases;
using ProyectoBiblioteca.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBiblioteca.Menus_biblioteca;
//using ProyectoBiblioteca.ClasesTemp;

namespace ProyectoBiblioteca.Clases.Menus_biblioteca
{
    public class MenuRegistro
    {
        CRUDLibros crud = new CRUDLibros();
        
        public void MenuSecundario()
        {
            string[] opciones = { "Registrar libro", "Editar registro de libro", "Eliminar registro de libro", "Regresar" };
            int opcionSeleccionada = 0;
            bool mostrarMenu = true;
            bool nuevaOpcionSeleccionada = true;

            FuncionesConsola.EstablecerTituloConsola("Gestión Biblioteca");

            while (mostrarMenu)
            {

                if (nuevaOpcionSeleccionada)
                {
                    Console.Clear();
                    DecoradorConsola.RecuadroMenu();
                    for (int i = 0; i < opciones.Length; i++)
                    {
                        Console.ForegroundColor = i == opcionSeleccionada ? ConsoleColor.Black : ConsoleColor.Gray;
                        Console.BackgroundColor = i == opcionSeleccionada ? ConsoleColor.Yellow : ConsoleColor.Black;
                        string prefijo = i == opcionSeleccionada ? "> " : "";
                        Console.Write("\t" + prefijo);
                        Console.WriteLine(opciones[i]);
                        Console.ResetColor();
                    }
                    //DecoradorConsola.Dibujar(opcionSeleccionada);
                    nuevaOpcionSeleccionada = false;
                }


                ConsoleKeyInfo tecla = Console.ReadKey(true);

                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    if (opcionSeleccionada > 0)
                    {
                        opcionSeleccionada--;
                        nuevaOpcionSeleccionada = true;
                    }

                }

                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    if (opcionSeleccionada < opciones.Length - 1)
                    {
                        opcionSeleccionada++;
                        nuevaOpcionSeleccionada = true;
                    }
                }

                if (tecla.Key == ConsoleKey.Enter)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n\n\tSeleccionado: {opciones[opcionSeleccionada]}.");
                    Console.ResetColor();

                    switch (opcionSeleccionada)
                    {
                        case 0:
                            DecoradorConsola.PantallaCarga();
                            crud.RegistrarLibro();
                            DecoradorConsola.OpcionRegresarMenu();
                            FuncionesConsola.Continuar();
                            MenuSecundario();
                            break;
                        case 1:
                            DecoradorConsola.PantallaCarga();
                            crud.EditarLibro();
                            DecoradorConsola.OpcionRegresarMenu();
                            FuncionesConsola.Continuar();
                            MenuSecundario();
                            break;
                        case 2:
                            DecoradorConsola.PantallaCarga();
                            crud.EliminarRegistroLibro();
                            DecoradorConsola.OpcionRegresarMenu();
                            FuncionesConsola.Continuar();
                            MenuSecundario();
                            break;
                        case 3:
                            Menu menu = new Menu();
                            menu.MenuInicio();
                            break;
                        default:
                            break;
                    }
                    mostrarMenu = false;
                }
            }
        }
    }
}
