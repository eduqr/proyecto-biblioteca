using ProyectoBiblioteca.Clases;
using ProyectoBiblioteca.Clases.Funciones_Consola;
using ProyectoBiblioteca.Contenedor;
using ProyectoBiblioteca.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoBiblioteca.CRUD
{
    internal class CRUDLibros
    {
        public void RegistrarLibro()
        {
            using (var _context = new ConexionBD())
            {
                Libros libro = new Libros();
                string valorIngresado;

                FuncionesConsola.EstablecerTituloConsola($"Agregar libro");

                Console.WriteLine("\n\t" + "Ingrese el título del libro:");
                Console.Write("\t> ");

                while (string.IsNullOrEmpty(valorIngresado = Console.ReadLine()))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\tEl valor de 'Título' no puede estar vacío.");
                    Console.ResetColor();
                    Console.Write("\t> ");
                }

                libro.Titulo = valorIngresado;

                Console.WriteLine("\n\t" + "Ingrese el ISBN del libro:");
                Console.Write("\t> ");

                while (string.IsNullOrEmpty(valorIngresado = Console.ReadLine()))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\tEl valor de 'ISBN' no puede estar vacío.");
                    Console.ResetColor();
                    Console.Write("\t> ");
                }

                libro.ISBN = valorIngresado;

                Console.WriteLine("\n\t" + "Ingrese el autor del libro:");
                Console.Write("\t> ");

                while (string.IsNullOrEmpty(valorIngresado = Console.ReadLine()))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\tEl valor de 'Autor' no puede estar vacío.");
                    Console.ResetColor();
                    Console.Write("\t> ");
                }

                libro.Autor = valorIngresado;

                Console.WriteLine("\n\t" + "Ingrese la editorial del libro:");
                Console.Write("\t> ");

                while (string.IsNullOrEmpty(valorIngresado = Console.ReadLine()))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\tEl valor de 'Editorial' no puede estar vacío.");
                    Console.ResetColor();
                    Console.Write("\t> ");
                }

                libro.Editorial = valorIngresado;

                Console.WriteLine("\n\t" + "Ingrese las unidades en existencia del libro");
                while (true)
                {
                    Console.Write("\t> ");
                    if (int.TryParse(Console.ReadLine(), out int unidades) && unidades > 0)
                    {
                        libro.Unidades = unidades;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\n\tSolo se admiten numeros enteros, ya que son unidades en existencia");
                        Console.ResetColor();
                    }
                }

                _context.Libros.Add(libro);
                _context.SaveChanges();
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\tLIBRO AGREGADO AL REGISTRO");
                Console.ResetColor();
                //DecoradorConsola.OpcionRegresarMenu();
            }
        }

        public void MostrarInventario()
        {
            using (var _context = new ConexionBD())
            {
                FuncionesConsola.EstablecerTituloConsola("Inventario");
                var cantidadLibros = _context.Libros.Count();
                if (cantidadLibros == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\tNo hay libros registrados aún.");
                    Console.WriteLine("\n\tAgregue libros al registro para poder visualizarlos aquí.");
                    Console.ResetColor();
                    return;
                }

                var libros = _context.Libros.ToList();

                DecoradorConsola.RecuadroInventario(cantidadLibros);
                Console.WriteLine("\t---------------------------------");
                foreach (var libro in libros)
                {
                    Console.WriteLine($"\tID: \t\t{libro.Id}");
                    Console.WriteLine($"\tTítulo: \t{libro.Titulo}");
                    Console.WriteLine($"\tISBN: \t\t{libro.ISBN}");
                    Console.WriteLine($"\tAutor: \t\t{libro.Autor}");
                    Console.WriteLine($"\tEditorial: \t{libro.Editorial}");
                    Console.WriteLine($"\tUnidades: \t{libro.Unidades}");
                    Console.WriteLine("\t---------------------------------");
                }
                //DecoradorConsola.OpcionRegresarMenu();
            }
        }

        public void EditarLibro()
        {
            using (var _context = new ConexionBD())
            {
                FuncionesConsola.EstablecerTituloConsola("Edición registro");
                var cantidadLibros = _context.Libros.Count();
                if (cantidadLibros == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\tNo hay libros registrados aún.");
                    Console.WriteLine("\n\tAgregue libros al registro para poder editarlos aquí si es necesario.");
                    Console.ResetColor();
                    return;
                }

                string titulo;
                Console.WriteLine("\n\tIngrese el título del libro a editar: ");
                Console.Write("\t> ");
                while (string.IsNullOrEmpty(titulo = Console.ReadLine()))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\tEl valor de 'Título' no puede estar vacío.");
                    Console.ResetColor();
                    Console.Write("\t> ");
                }

                Libros libro = _context.Libros.FirstOrDefault(c => c.Titulo == titulo);
                FuncionesConsola.EstablecerTituloConsola($"Editando registro de {titulo}");
                
                if (libro != null)
                {
                    string valorIngresado;

                    Console.WriteLine("\n\t" + "Ingrese el título del libro:");
                    Console.Write("\t> ");

                    while (string.IsNullOrEmpty(valorIngresado = Console.ReadLine()))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\n\tEl valor de 'Título' no puede estar vacío.");
                        Console.ResetColor();
                        Console.Write("\t> ");
                    }

                    libro.Titulo = valorIngresado;

                    Console.WriteLine("\n\t" + "Ingrese el ISBN del libro:");
                    Console.Write("\t> ");

                    while (string.IsNullOrEmpty(valorIngresado = Console.ReadLine()))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\n\tEl valor de 'ISBN' no puede estar vacío.");
                        Console.ResetColor();
                        Console.Write("\t> ");
                    }

                    libro.ISBN = valorIngresado;

                    Console.WriteLine("\n\t" + "Ingrese el autor del libro:");
                    Console.Write("\t> ");

                    while (string.IsNullOrEmpty(valorIngresado = Console.ReadLine()))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\n\tEl valor de 'Autor' no puede estar vacío.");
                        Console.ResetColor();
                        Console.Write("\t> ");
                    }

                    libro.Autor = valorIngresado;

                    Console.WriteLine("\n\tIngrese las unidades en existencia del libro:");
                    while (true)
                    {
                        Console.Write("\t> ");
                        if (int.TryParse(Console.ReadLine(), out int unidades) && unidades > 0)
                        {
                            libro.Unidades = unidades;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\n\tSolo se admiten numeros enteros, ya que son unidades en existencia");
                            Console.ResetColor();
                        }
                    }

                    _context.Libros.Update(libro);
                    _context.SaveChanges();
                    Console.WriteLine();
                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\tLIBRO EDITADO CORRECTAMENTE");
                    Console.ResetColor();
                    //DecoradorConsola.OpcionRegresarMenu();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tEL LIBRO NO EXISTE EN EL REGISTRO");
                    Console.ResetColor();
                    //DecoradorConsola.OpcionRegresarMenu();
                }
            }
        }

        public void EliminarRegistroLibro()
        {
            using (var _context = new ConexionBD())
            {
                FuncionesConsola.EstablecerTituloConsola("Eliminar registro");
                var cantidadLibros = _context.Libros.Count();
                if (cantidadLibros == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\tNo hay libros registrados aún.");
                    Console.WriteLine("\n\tAgregue libros al registro para poder eliminarlos si es necesario.");
                    Console.ResetColor();
                    return;
                }

                string titulo;
                Console.WriteLine("\n\tIngrese el título del libro a eliminar: ");
                Console.Write("\t> ");                
                while (string.IsNullOrEmpty(titulo = Console.ReadLine()))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\tEl valor de 'Título' no puede estar vacío.");
                    Console.ResetColor();
                    Console.Write("\t> ");
                }

                Libros libro = _context.Libros.FirstOrDefault(c => c.Titulo == titulo);
                FuncionesConsola.EstablecerTituloConsola($"Eliminando a {titulo}");
                if (libro != null)
                {
                    _context.Libros.Remove(libro);
                    _context.SaveChanges();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tLIBRO ELIMINADO");
                    Console.ResetColor();
                    //DecoradorConsola.OpcionRegresarMenu();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tEL LIBRO NO EXISTE EN EL REGISTRO");
                    Console.ResetColor();
                    //DecoradorConsola.OpcionRegresarMenu();
                }
            }
        }
    }
}
