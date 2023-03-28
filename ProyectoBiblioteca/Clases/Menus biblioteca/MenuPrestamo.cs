using ProyectoBiblioteca.Clases.Funciones_Consola;
using ProyectoBiblioteca.CRUD;
using ProyectoBiblioteca.Menus_biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases.Menus_biblioteca
{
    public class MenuPrestamo
    {
        CRUDPrestamos crudprestamos = new CRUDPrestamos();
        public void MenuPrestamos()
        {
            string[] opciones = { "Registrar prestamo", "Editar prestamos", "Eliminar prestamos", "Mostrar prestamos", "Regresar" };
            int opcionSeleccionada = 0;
            bool mostrarMenu = true;
            bool nuevaOpcionSeleccionada = true;

            FuncionesConsola.EstablecerTituloConsola("Gestión de Prestamos");

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
                            crudprestamos.RegistrarPrestamo();
                            DecoradorConsola.OpcionRegresarMenu();
                            FuncionesConsola.Continuar();
                            MenuPrestamos();
                            break;
                        case 1:
                            DecoradorConsola.PantallaCarga();
                            crudprestamos.EditarPrestamo();
                            DecoradorConsola.OpcionRegresarMenu();
                            FuncionesConsola.Continuar();
                            MenuPrestamos();
                            break;
                        case 2:
                            DecoradorConsola.PantallaCarga();
                            crudprestamos.EliminarPrestamo();
                            DecoradorConsola.OpcionRegresarMenu();
                            FuncionesConsola.Continuar();
                            MenuPrestamos();
                            break;
                        case 3:
                            DecoradorConsola.PantallaCarga();
                            crudprestamos.MostrarPrestamos();
                            DecoradorConsola.OpcionRegresarMenu();
                            FuncionesConsola.Continuar();
                            MenuPrestamos();
                            break;
                        case 4:
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