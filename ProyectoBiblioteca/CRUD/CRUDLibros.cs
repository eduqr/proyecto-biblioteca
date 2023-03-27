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
                Console.Clear();
                Console.WriteLine("Ingrese el título del libro:");
                Console.Write("> ");
                libro.Titulo = Console.ReadLine();
                Console.WriteLine("\nIngrese el ISBN del libro:");
                Console.Write("> ");
                libro.ISBN = Console.ReadLine();
                Console.WriteLine("\nIngrese el autor del libro:");
                Console.Write("> ");
                libro.Autor = Console.ReadLine();
                Console.WriteLine("\nIngrese la editorial del libro:");
                Console.Write("> ");
                libro.Editorial = Console.ReadLine();
                Console.WriteLine("\nIngrese las unidades en existencia del libro");
                Console.Write("> ");
                while (true)
                {
                    try
                    {
                        libro.Unidades = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("\nSolo se admiten numeros enteros, ya que son unidades en existencia");
                        Console.Write("> ");
                    }
                }
                _context.Libros.Add(libro);
                _context.SaveChanges();
                Console.WriteLine("\nLibro guardado!");
            }
        }

        public void MostrarInventario()
        {
            using (var _context = new ConexionBD())
            {
                var libros = _context.Libros.ToList();
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t" + "Inventario de libros:");
                Console.WriteLine();
                Console.WriteLine("---------------------------------");
                foreach (var libro in libros)
                {
                    Console.WriteLine($"ID: \t\t{libro.Id}");
                    Console.WriteLine($"Título: \t{libro.Titulo}");
                    Console.WriteLine($"ISBN: \t\t{libro.ISBN}");
                    Console.WriteLine($"Autor: \t\t{libro.Autor}");
                    Console.WriteLine($"Editorial: \t{libro.Editorial}");
                    Console.WriteLine($"Unidades: \t{libro.Unidades}");
                    Console.WriteLine("---------------------------------");
                    
                }
            }
        }

        public void EditarLibro(string titulo)
        {
            using (var _context = new ConexionBD())
            {
                Console.Clear();
                Libros libro = _context.Libros.FirstOrDefault(c => c.Titulo == titulo);
                FuncionesConsola.EstablecerTituloConsola($"Editando a {titulo}");
                if (libro != null)
                {
                    Console.WriteLine("Ingrese el título del libro:");
                    Console.Write("> ");
                    libro.Titulo = Console.ReadLine();
                    Console.WriteLine("\nIngrese el ISBN del libro:");
                    Console.Write("> ");
                    libro.ISBN = Console.ReadLine();
                    Console.WriteLine("\nIngrese el autor del libro:");
                    Console.Write("> ");
                    libro.Autor = Console.ReadLine();
                    Console.WriteLine("\nIngrese la editorial del libro:");
                    Console.Write("> ");
                    libro.Editorial = Console.ReadLine();
                    Console.WriteLine("\nIngrese las unidades en existencia del libro");
                    Console.Write("> ");
                    while (true)
                    {
                        try
                        {
                            libro.Unidades = int.Parse(Console.ReadLine());
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("\nSolo se admiten numeros enteros, ya que son unidades en existencia");
                            Console.Write("> ");
                        }
                    }
                    _context.Libros.Update(libro);
                    _context.SaveChanges();
                    Console.WriteLine();
                    Console.WriteLine("\nLIBRO EDITADO CON ÉXITO");
                }
                else
                {
                    Console.WriteLine("El libro no existe.");
                }
            }
        }

        public void EliminarRegistroLibro(string titulo)
        {
            using (var _context = new ConexionBD())
            {
                Console.Clear();
                Libros libro = _context.Libros.FirstOrDefault(c => c.Titulo == titulo);
                FuncionesConsola.EstablecerTituloConsola($"Eliminando a {titulo}");
                if (libro != null)
                {
                    _context.Libros.Remove(libro);
                    _context.SaveChanges();
                    Console.WriteLine();
                    Console.WriteLine("\nLIBRO ELIMINADO CON ÉXITO");
                }
                else
                {
                    Console.WriteLine("El libro no existe.");
                }
            }
        }
    }
}
