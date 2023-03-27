using ProyectoBiblioteca.Clases.Funciones_Consola;
using ProyectoBiblioteca.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases.Menus_biblioteca
{
    public class MenuRegistro
    {
        // MOSTRAR MENU SECUNDARIO
        // AQUI SE LLAMARÁN A LAS FUNCIONES DEL CRUD
        CRUDLibros crud = new CRUDLibros();
        public void MenuSecundario()
        {
            string[] opciones = { "Registrar libro", "Editar registro de libro", "Eliminar registro de libro" };
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
                    Console.WriteLine($"Seleccionaste la opción de {opciones[opcionSeleccionada]}.");

                    switch (opcionSeleccionada)
                    {
                        case 0:
                            // FUNCIÓN LLAMAR REGISTRO DE LIBRO
                            crud.RegistrarLibro();
                            break;
                        case 1:
                            // FUNCIÓN PARA EDITAR REGISTRO
                            
                            break;
                        case 2:
                            // FUNCIÓN PARA ELIMINAR REGISTRO

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
