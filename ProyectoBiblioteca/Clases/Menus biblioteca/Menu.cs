using ProyectoBiblioteca.Clases;
using ProyectoBiblioteca.Clases.Funciones_Consola;
using ProyectoBiblioteca.Clases.Menus_biblioteca;
using ProyectoBiblioteca.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.ClasesTemp
{
    public class Menu
    {
        CRUDLibros crud = new CRUDLibros();
        public void MenuInicio()
        {
            string[] opciones = { "Gestionar biblioteca", "Ver catálogo de libros", "Salir" };
            int opcionSeleccionada = 0;
            bool mostrarMenu = true;
            bool nuevaOpcionSeleccionada = true;

            FuncionesConsola.EstablecerTituloConsola("Menú");
            
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
                    DecoradorConsola.Dibujar(opcionSeleccionada);
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
                    Console.WriteLine($"Seleccionaste la opción de {opciones[opcionSeleccionada]}.");

                    switch (opcionSeleccionada)
                    {
                        case 0:
                            // FUNCIÓN LLAMAR MENU REGISTRO
                            MenuRegistro menuRegistro = new MenuRegistro();
                            menuRegistro.MenuSecundario();
                            break;
                        case 1:
                            // FUNCIÓN PARA MOSTRAR CATÁLOGO
                            crud.MostrarInventario();
                            break;
                        case 2:
                            // CAMBIAR A FUNCION SALIR
                            // CREARLA FuncionesConsola
                            Console.WriteLine("Presiona cualquier tecla para salir.");
                            Console.ReadKey();
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
