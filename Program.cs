using System;
using System.Collections.Generic;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            var diasemana = new List<string>();
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(5);
            numeros.Add(55);
            numeros.Add(95);
            diasemana.Add("Lunes");
            diasemana.Add("Martes");
            diasemana.Add("Miercoles");
            diasemana.Add("Jueves");
            diasemana.Add("Viernes");
            diasemana.Add("Sabado");
            diasemana.Add("Domingo");
            Console.WriteLine("esta lista de numeros");
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("esta es la lista de los dias de la semana");
            foreach (var item2 in diasemana)
            {
                Console.WriteLine(item2);
            }
            Console.WriteLine("eliminando el dia domingo de la lista semana");
            diasemana.Remove("Domingo");
            foreach (var item2 in diasemana)
            {
                Console.WriteLine(item2);
            }
            Console.ReadLine();
        } 

    } 
}
