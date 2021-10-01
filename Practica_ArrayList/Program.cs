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
                //conteo de elementos en matriz
                int nelementos = Notas2.Count; //Numero de elementos en la matriz
                int nalumnos = nelementos; //Numero de alumnos

                //Insertar un elemento
                Console.WriteLine("Si desea insertar una nota media adicional, ingrese 'si', caso contrario ingrese 'no'");
                string decision = Console.ReadLine();

                if (decision == "si")
                {
                    nalumnos = nalumnos + 1;
                    //posicion de la matriz en la que se agregara la nueva nota media
                    int nalumni = nelementos;
                    Console.WriteLine("Introducir nueva nota media para alumno numero {0,3:D}", i);
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

                //Obtener el valor de un elemento
                Console.WriteLine("Si desea obtener el valor de una de la notas medias ya ingresadas, ingrese 'si', caso contrario ingrese 'no'");
                string condicion2 = Console.ReadLine();

                if (condicion2 == "si")
                {
                    Console.WriteLine("Introducir alumno al cual desea buscar la nota");
                    //posicion de la matriz
                    int busq = int.Parse(Console.ReadLine());
                    //nueva variable ya que la matriz empieca desde 0 y automaticamente agregara uno en la posicion
                    int ind = busq - 1;
                    //obtiene elemento
                    float found = (float)Notas2[ind];
                    //Muestra nota obtenida
                    Console.WriteLine("Para el alumno " + busq + " se ingreso la nota media de: " + found);
                }
                else if (condicion2 == "no")
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
