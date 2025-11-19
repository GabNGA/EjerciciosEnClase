using System;

namespace BusquedaBinariaPractica
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numeros = new int[30];
            Random aleatorio = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = aleatorio.Next(1, 101); 
            }

            
            Array.Sort(numeros);

            Console.WriteLine("Arreglo ordenado:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }
            Console.WriteLine("\n");

            
            Console.Write("Ingrese un número a buscar: ");
            int buscado;
            while (!int.TryParse(Console.ReadLine(), out buscado))
            {
                Console.Write("Valor inválido. Ingrese un número entero: ");
            }

            
            int izquierda = 0;
            int derecha = numeros.Length - 1;
            bool encontrado = false;
            int posicion = -1;
            int paso = 1;

            Console.WriteLine("\n--- Proceso de búsqueda ---");

            while (izquierda <= derecha)
            {
                int mitad = (izquierda + derecha) / 2;

                Console.WriteLine($"\nPaso {paso}:");
                Console.WriteLine($"Izquierda = {izquierda}, Derecha = {derecha}, Mitad = {mitad}");
                Console.WriteLine($"Valor en mitad = {numeros[mitad]}");

                if (numeros[mitad] == buscado)
                {
                    encontrado = true;
                    posicion = mitad;
                    Console.WriteLine("→ El valor es igual al de la mitad. ¡Encontrado!");
                    break;
                }
                else if (buscado < numeros[mitad])
                {
                    Console.WriteLine("→ El número buscado es MENOR. Ahora busco en la parte izquierda.");
                    derecha = mitad - 1;
                }
                else
                {
                    Console.WriteLine("→ El número buscado es MAYOR. Ahora busco en la parte derecha.");
                    izquierda = mitad + 1;
                }

                paso++;
            }

           

        }

    }
}