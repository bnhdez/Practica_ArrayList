using System;
using System.Collections;

namespace Practica_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //matriz notas inicialmente vacia 
            ArrayList notas = new ArrayList();

            //entrada de datos
            int i = 0;
            Console.WriteLine("Introducir notas medias. Finalizar con -1");
            Console.WriteLine("Alumno numero {0,3:D}, nota media: ", ++i);
            float nota = float.Parse(Console.ReadLine());
            while (nota != -1)
            {
                notas.Add(nota); //añadir un elemento
                Console.WriteLine("Alumno numero {0,3:D}, nota media: ", ++i);

                nota = float.Parse(Console.ReadLine());
            }

            //Sumar las notas
            float suma = 0;
            foreach (float notaMedia in notas)
                suma += notaMedia;


            //Escribir los resultados
            int nalumnos = notas.Count; //Numero de alumnos
            Console.WriteLine("El PROMEDIO ES " + suma / nalumnos);

        }
    }
}
