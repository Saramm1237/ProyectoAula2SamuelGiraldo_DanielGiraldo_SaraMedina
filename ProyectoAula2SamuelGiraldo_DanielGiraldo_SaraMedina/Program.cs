﻿using System;
using System.Collections.Generic;

namespace ProyectoAula2
{
       public class Program
    {
        public static void Main()
        {
            List<IdeaDeNegocio> ideas = new List<IdeaDeNegocio>();

            while (true)
            {
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("1. Ingresar idea de negocio");
                Console.WriteLine("2. Agregar integrante a idea de negocio");
                Console.WriteLine("3. Eliminar integrantes");
                Console.WriteLine("4. Modificar valor de inversión");
                Console.WriteLine("5. Mostrar información");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        IdeaDeNegocio idea = IngresarIdeaDeNegocio();
                        ideas.Add(idea);
                        break;

                    case 2:
                        Console.Write("Ingrese el código de la idea de negocio: ");
                        string codigo = Console.ReadLine();
                        IdeaDeNegocio ideaAEquipo = ideas.Find(x => x.Codigo == codigo);

                        if (ideaAEquipo != null)
                        {
                            Integrante integrante = IngresarIntegrante();
                            ideaAEquipo.AgregarIntegrante(integrante);
                        }
                        else
                        {
                            Console.WriteLine("Idea de negocio no encontrada.");
                        }
                        break;

                    case 3:
                        Console.Write("Ingrese el código de la idea de negocio: ");
                        codigo = Console.ReadLine();
                        ideaAEquipo = ideas.Find(x => x.Codigo == codigo);

                        if (ideaAEquipo != null)
                        {
                            Console.Write("Ingrese la identificación del integrante a eliminar: ");
                            string id = Console.ReadLine();
                            ideaAEquipo.EliminarIntegrante(id);
                        }
                        else
                        {
                            Console.WriteLine("Idea de negocio no encontrada.");
                        }
                        break;

                    case 4:
                        Console.Write("Ingrese el código de la idea de negocio: ");
                        codigo = Console.ReadLine();
                        ideaAEquipo = ideas.Find(x => x.Codigo == codigo);

                        if (ideaAEquipo != null)
                        {
                            Console.Write("Nuevo valor de inversión: ");
                            double nuevoValor = double.Parse(Console.ReadLine());
                            ideaAEquipo.ModificarInversion(nuevoValor);
                        }
                        else
                        {
                            Console.WriteLine("Idea de negocio no encontrada.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Información de las ideas de negocio:");
                        foreach (var ideaNegocio in ideas)
                        {
                            Console.WriteLine($"Código: {ideaNegocio.Codigo}");
                            Console.WriteLine($"Nombre: {ideaNegocio.Nombre}");
                            Console.WriteLine($"Inversión: {ideaNegocio.Inversion}");
                            Console.WriteLine("Integrantes:");
                            foreach (var integrante in ideaNegocio.Integrantes)
                            {
                                Console.WriteLine($"- {integrante.Nombre} ({integrante.Rol})");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }

        public static IdeaDeNegocio IngresarIdeaDeNegocio()
        {
            Console.WriteLine("Ingrese los datos de la idea de negocio:");
            Console.Write("Código: ");
            string codigo = Console.ReadLine();
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Inversión inicial: ");
            double inversion = double.Parse(Console.ReadLine());

            IdeaDeNegocio idea = new IdeaDeNegocio
            {
                Codigo = codigo,
                Nombre = nombre,
                Inversion = inversion
            };

            return idea;
        }

        public static Integrante IngresarIntegrante()
        {
            Console.WriteLine("Ingrese los datos del integrante:");
            Console.Write("Identificación: ");
            string identificacion = Console.ReadLine();
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellidos: ");
            string apellidos = Console.ReadLine();
            Console.Write("Rol dentro del emprendimiento: ");
            string rol = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            return new Integrante
            {
                Identificacion = identificacion,
                Nombre = nombre,
                Apellidos = apellidos,
                Rol = rol,
                Email = email
            };
        }
    }

    public class IdeaDeNegocio
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public List<Integrante> Integrantes { get; set; }
        public double Inversion { get; set; }

        public IdeaDeNegocio()
        {
            Integrantes = new List<Integrante>();
        }

        public void AgregarIntegrante(Integrante integrante)
        {
            Integrantes.Add(integrante);
        }

        public void EliminarIntegrante(string identificacion)
        {
            Integrante integranteAEliminar = Integrantes.Find(x => x.Identificacion == identificacion);
            if (integranteAEliminar != null)
            {
                Integrantes.Remove(integranteAEliminar);
            }
            else
            {
                Console.WriteLine("Integrante no encontrado.");
            }
        }

        public void ModificarInversion(double nuevoValor)
        {
            Inversion = nuevoValor;
        }
    }

    public class Integrante
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Rol { get; set; }
        public string Email { get; set; }
    }

}