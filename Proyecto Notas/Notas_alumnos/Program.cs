using System;
using System.Collections.Generic;


namespace alumnos
{
    class Program

    {
        static void Main(string [] args)
        {
            string[] alumnos;
            double[,] notas;
            string alumno= "";
           
            
            
            Console.WriteLine("Calculo de Calificaciones de Alumnos");
            Console.WriteLine("=====================================");
            Console.WriteLine("");

            Console.Write("Cuantos alumnos desea ingresar: ");
            int numAlumnos = Int32.Parse(Console.ReadLine());

            alumnos = new string[numAlumnos];
            notas = new double[numAlumnos, 3];

            for (int i = 0; i < numAlumnos; i++)
            {

            Console.WriteLine("\nAlumno " + (i+1));
            Console.WriteLine("Ingrese el Nombre del alumno: ");
            alumnos[i] = Console.ReadLine();
            Console.WriteLine("");

             for (int j = 0; j < 3; j++)
                {
                    Console.Write("Nota #{0}: ", (j+1));
                    notas[i, j] = Double.Parse(Console.ReadLine());
                }
                Console.WriteLine("\n***Alumno Registrado***\n");
                Console.WriteLine("");

            }
          
            for (int i = 0; i < numAlumnos; i++)
            {
           
                
                double sumaNotas = 0d;
                for (int j = 0; j < 3; j++)
                sumaNotas += notas[i, j];


               
                double promedio = sumaNotas / 3d;

                if (promedio < 65)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Reprobado");
                    
                }
                if (promedio >=65)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    Console.WriteLine("Aprovado");
                    
                }
                 
                Console.WriteLine("");
                Console.WriteLine("{0} --> {1:f2} ", alumnos[i], promedio);
            }

            Console.ReadKey();

        }

            



        }



    }



