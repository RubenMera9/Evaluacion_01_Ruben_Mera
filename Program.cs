using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la cantidad de números:");
        int cantidad = int.Parse(Console.ReadLine());

        int[] numeros = new int[cantidad];

        // Pedir al usuario que ingrese los números
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Ordenar los números usando el método de burbuja
        OrdenarNumeros(numeros);

        // Mostrar los números ordenados
        Console.WriteLine("\nNúmeros ordenados:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }

        Console.ReadLine();
    }

    static void OrdenarNumeros(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Intercambiar elementos si están en el orden incorrecto
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
