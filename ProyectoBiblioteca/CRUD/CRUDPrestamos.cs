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
    public class CRUDPrestamos
    {
        public void RegistrarPrestamo()
        {
            FuncionesConsola.EstablecerTituloConsola("Registro préstamo");

            using (var _context = new ConexionBD())
            {
                Prestamo prestamo = new Prestamo();

                string valorIngresado;

                Console.WriteLine("\n\t" + "Ingrese el nombre del alumno:");
                Console.Write("\t> ");
                while (string.IsNullOrEmpty(valorIngresado = Console.ReadLine()))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\tEl valor no puede estar vacío.");
                    Console.ResetColor();
                    Console.Write("\t> ");
                }
                prestamo.Alumno = valorIngresado;
                
                Console.WriteLine("\n\t" + "Ingrese la matrícula del alumno:");
                Console.Write("\t> ");
                while (string.IsNullOrEmpty(valorIngresado = Console.ReadLine()))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\tEl valor no puede estar vacío.");
                    Console.ResetColor();
                    Console.Write("\t> ");
                }
                prestamo.Matricula = valorIngresado;
                
                Console.WriteLine("\n\t" + "Ingrese el correo del alumno:");
                Console.Write("\t> ");
                while (string.IsNullOrEmpty(valorIngresado = Console.ReadLine()))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\tEl valor no puede estar vacío.");
                    Console.ResetColor();
                    Console.Write("\t> ");
                }
                prestamo.Correo = valorIngresado;
                
                Console.WriteLine("\n\t" + "Ingrese el libro a prestar:");
                Console.Write("\t> ");
                while (string.IsNullOrEmpty(valorIngresado = Console.ReadLine()))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\tEl valor no puede estar vacío.");
                    Console.ResetColor();
                    Console.Write("\t> ");
                }
                prestamo.TituloLibroPrestado = valorIngresado;
                
                prestamo.FechaPedido = DateTime.Now;
                prestamo.FechaRegreso = prestamo.FechaPedido.AddDays(3);

                _context.Prestamo.Add(prestamo);
                _context.SaveChanges();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine("\t" + "PRÉSTAMO REGISTRADO CORRECTAMENTE");
                Console.ResetColor();
            }
        }

        public void EditarPrestamo()
        {
            FuncionesConsola.EstablecerTituloConsola("Editar préstamo");
            
            using (var _context = new ConexionBD())
            {
                var cantidadPrestamos = _context.Prestamo.Count();
                if (cantidadPrestamos == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\tNo hay préstamos registrados aún.");
                    Console.WriteLine("\n\tAl registrar un préstamo podrá editarlo aquí si es necesario.");
                    Console.ResetColor();
                    return;
                }

                string matricula;
                Console.WriteLine("\n\tIngrese la matrícula del estudiante: ");
                Console.Write("\t> ");
                while (string.IsNullOrEmpty(matricula = Console.ReadLine()))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\tEl valor no puede estar vacío.");
                    Console.ResetColor();
                    Console.Write("\t> ");
                }

                Prestamo prestamo = _context.Prestamo.FirstOrDefault(c => c.Matricula == matricula);
                FuncionesConsola.EstablecerTituloConsola($"Editando préstamo de {matricula}");

                if (prestamo != null)
                {
                    string valorIngresado;

                    Console.WriteLine("\n\t" + "Ingrese el nombre del alumno:");
                    Console.Write("\t> ");
                    while (string.IsNullOrEmpty(valorIngresado = Console.ReadLine()))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\n\tEl valor no puede estar vacío.");
                        Console.ResetColor();
                        Console.Write("\t> ");
                    }
                    prestamo.Alumno = valorIngresado;

                    Console.WriteLine("\n\t" + "Ingrese la matrícula del alumno:");
                    Console.Write("\t> ");
                    while (string.IsNullOrEmpty(valorIngresado = Console.ReadLine()))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\n\tEl valor no puede estar vacío.");
                        Console.ResetColor();
                        Console.Write("\t> ");
                    }
                    prestamo.Matricula = valorIngresado;

                    Console.WriteLine("\n\t" + "Ingrese el correo del alumno:");
                    Console.Write("\t> ");
                    while (string.IsNullOrEmpty(valorIngresado = Console.ReadLine()))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\n\tEl valor no puede estar vacío.");
                        Console.ResetColor();
                        Console.Write("\t> ");
                    }
                    prestamo.Correo = valorIngresado;

                    Console.WriteLine("\n\t" + "Ingrese el libro a prestar:");
                    Console.Write("\t> ");
                    while (string.IsNullOrEmpty(valorIngresado = Console.ReadLine()))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\n\tEl valor no puede estar vacío.");
                        Console.ResetColor();
                        Console.Write("\t> ");
                    }
                    prestamo.TituloLibroPrestado = valorIngresado;

                    prestamo.FechaPedido = DateTime.Now;
                    prestamo.FechaRegreso = prestamo.FechaPedido.AddDays(3);

                    _context.Prestamo.Update(prestamo);
                    _context.SaveChanges();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();
                    Console.WriteLine("\t" + "PRÉSTAMO REGISTRADO CORRECTAMENTE");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tNO EXISTE UN PRÉSTAMO ASOCIADO A LA MATRÍCULA PROPORCIONADA");
                    Console.ResetColor();
                    //DecoradorConsola.OpcionRegresarMenu();
                }
            }
        }

        public void EliminarPrestamo()
        {
            FuncionesConsola.EstablecerTituloConsola("Editar préstamo");

            using (var _context = new ConexionBD())
            {
                var cantidadPrestamos = _context.Prestamo.Count();
                if (cantidadPrestamos == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\tNo hay préstamos registrados aún.");
                    Console.WriteLine("\n\tAl registrar un préstamo podrá eliminarlo aquí cuando sea necesario.");
                    Console.ResetColor();
                    return;
                }

                string matricula;
                Console.WriteLine("\n\tIngrese la matrícula asociada al préstamo: ");
                Console.Write("\t> ");
                while (string.IsNullOrEmpty(matricula = Console.ReadLine()))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\tEl valor no puede estar vacío.");
                    Console.ResetColor();
                    Console.Write("\t> ");
                }

                Prestamo prestamo = _context.Prestamo.FirstOrDefault(c => c.Matricula == matricula);
                FuncionesConsola.EstablecerTituloConsola($"Eliminando préstamo de {matricula}");

                if(prestamo != null )
                {
                    _context.Prestamo.Remove(prestamo);
                    _context.SaveChanges();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tPRÉSTAMO ELIMINADO");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tNO EXISTE UN REGISTRO ASOCIADO A LA MATRÍCULA PROPORCIONADA");
                    Console.ResetColor();
                }
            }
        }

        public void MostrarPrestamos()
        {
            FuncionesConsola.EstablecerTituloConsola("Préstamos actuales");

            using (var _context = new ConexionBD())
            {
                var cantidadPrestamos = _context.Prestamo.Count();
                if (cantidadPrestamos == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\tNo hay préstamos registrados aún.");
                    Console.WriteLine("\n\tAl registrar un préstamo podrá visualizarlo aquí.");
                    Console.ResetColor();
                    return;
                }

                var prestamo = _context.Prestamo.ToList();
                DecoradorConsola.RecuadroPrestamos(cantidadPrestamos);
                Console.WriteLine("\t---------------------------------");
                foreach(var item in prestamo)
                {
                    Console.WriteLine($"\tID: \t\t{item.Id}");
                    Console.WriteLine($"\tAlumno: \t{item.Alumno}");
                    Console.WriteLine($"\tMatrícula: \t{item.Matricula}");
                    Console.WriteLine($"\tCorreo: \t{item.Correo}");
                    Console.WriteLine($"\tLibro prestado: {item.TituloLibroPrestado}");
                    Console.WriteLine($"\tFecha pedido: \t{item.FechaPedido}");
                    Console.WriteLine($"\tFecha regreso: \t{item.FechaRegreso}");
                    Console.WriteLine("\t---------------------------------");
                }
            }
        }
    }
}
