using System;
using System.Collections;

namespace Practica_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Invocar metodo clone
            Clone();

            static void Clone()
            {
                //matriz notas inicialmente vacia 
                ArrayList Notas2 = new ArrayList();

                //entrada de datos
                int i = 0;
                Console.WriteLine("Introducir notas medias. Finalizar con -1");
                Console.WriteLine("Alumno numero {0,3:D}, nota media: ", ++i);
                float nota = float.Parse(Console.ReadLine());
                while (nota != -1)
                {
                    Notas2.Add(nota); //añadir un elemento
                    Console.WriteLine("Alumno numero {0,3:D}, nota media: ", ++i);

                    nota = float.Parse(Console.ReadLine());
                }
                int nalumnos = Notas2.Count; //Numero de alumnos

                //Insertar un elemento
                Console.WriteLine("Si desea agregar una nota media adicional, ingrese 'si', caso contrario ingrese 'no'");
                string decision = Console.ReadLine();

                if (decision == "si")
                {
                    //posicion de la matriz
                    int nalumni = nalumnos - 1;
                    //nueva variable ya que la matriz empieca desde 0 y automaticamente agregara uno en la posicion
                    int pos = nalumni - 1;
                    Console.WriteLine("Introducir nueva nota media");
                    float nota2 = float.Parse(Console.ReadLine());
                    Notas2.Insert(nalumni, nota2);
                }
                else if (decision == "no")
                {
                    Console.WriteLine();
                }

                //Modificar un elemento
                Console.WriteLine("Si desea modificar una de la notas medias ya ingresadas, ingrese 'si', caso contrario ingrese 'no'");
                string condicion = Console.ReadLine();

                if (condicion == "si")
                {
                    Console.WriteLine("Introducir alumno a modificar");
                    //posicion de la matriz
                    int alumni = int.Parse(Console.ReadLine());
                    //nueva variable ya que la matriz empieca desde 0 y automaticamente agregara uno en la posicion
                    int rango = alumni - 1;
                    Console.WriteLine("Introducir nuva nota ");
                    float n_nota = float.Parse(Console.ReadLine());
                    Notas2[rango] = n_nota;
                }
                else if (condicion == "no")
                {
                    Console.WriteLine();
                }

                //Sumar las notas
                float suma = 0;
                foreach (float notaMedia in Notas2)
                    suma += notaMedia;


                //Escribir los resultados
                Console.WriteLine("El PROMEDIO ES " + suma / nalumnos);
            }
        
        }
    }
}
