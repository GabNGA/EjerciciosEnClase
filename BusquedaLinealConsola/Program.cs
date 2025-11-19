using System;

namespace BusquedaLinealConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numeros = new int[20];
            Random aleatorio = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = aleatorio.Next(1, 101); 
            }

            
            Console.WriteLine("Arreglo generado (20 números aleatorios):");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }
            Console.WriteLine(); 

            
            Console.Write("\nIngrese un número a buscar: ");
            int buscado;

            
            while (!int.TryParse(Console.ReadLine(), out buscado))
            {
                Console.Write("Entrada inválida. Ingrese un número entero: ");
            }

            
            bool encontrado = false;
            int posicion = -1;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscado)
                {
                    encontrado = true;
                    posicion = i; 
                    break;        
                }
            }

            
            if (encontrado)
            {
                Console.WriteLine($"\nEl número {buscado} SÍ existe en el arreglo.");
                Console.WriteLine($"Se encuentra en la posición: {posicion} (empezando desde 0).");
            }
            else
            {
                Console.WriteLine($"\nEl número {buscado} NO existe en el arreglo.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
