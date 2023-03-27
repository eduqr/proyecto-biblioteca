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
                Console.WriteLine("Ingrese el título del libro:");
                libro.Titulo = Console.ReadLine();
                Console.WriteLine("\nIngrese el ISBN del libro:");
                libro.ISBN = Console.ReadLine();
                Console.WriteLine("\nIngrese el autor del libro:");
                libro.Autor = Console.ReadLine();
                Console.WriteLine("\nIngrese la editorial del libro:");
                libro.Editorial = Console.ReadLine();
                Console.WriteLine("\nIngrese las unidades en existencia del libro");
                while (true)
                {
                    try
                    {
                        libro.Unidades = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Solo se admiten numeros enteros, ya que son unidades en existencia");
                    }
                }
                _context.Libros.Add(libro);
                _context.SaveChanges();
            }
        }

        public void MostrarInventario()
        {
            using (var _context = new ConexionBD())
            {
                var libros = _context.Libros.ToList();

                Console.WriteLine("Inventario de libros:");
                Console.WriteLine("---------------------");
                foreach (var libro in libros)
                {
                    Console.WriteLine($"ID: {libro.Id}");
                    Console.WriteLine($"Título: {libro.Titulo}");
                    Console.WriteLine($"ISBN: {libro.ISBN}");
                    Console.WriteLine($"Autor: {libro.Autor}");
                    Console.WriteLine($"Editorial: {libro.Editorial}");
                    Console.WriteLine($"Unidades: {libro.Unidades}");
                    Console.WriteLine("---------------------");
                }
            }
        }

        public void EditarLibro()
        {
            // no hacer este
        }

        public void EliminarRegistroLibro()
        {

        }
    }
}
