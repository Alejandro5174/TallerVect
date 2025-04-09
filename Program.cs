using System;

namespace TallerVect;
class Program
{
    static void Main()
    {
      Arreglos();        
      AlmacenamientoEmpresa();        
      TorneoDeFutbol();
        
    }
    static void Arreglos()
    {
        int[] arreglo1 = new int[7];
        int[] arreglo2 = new int[7];
        int[] arreglo3 = new int[7];

        Console.WriteLine("Ingrese los 7 numeros enteros para el arreglo 1");
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Ingrese el valor {i + 1}: ");
            arreglo1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Ingrese los 7 numeros enteros para el arreglo 2");
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Ingrese el valor {i + 1}: ");
            arreglo2[i] = int.Parse(Console.ReadLine());
        }

        int suma = 0;
        for (int i = 0; i < 7; i++)
        {
            arreglo3[i] = arreglo1[i] - arreglo2[i];
            suma += arreglo3[i];
            Console.WriteLine($"La resta de {arreglo1[i]} - {arreglo2[i]} es: {arreglo3[i]}");
        }
        double promedio = suma / 7.0;
        Console.WriteLine($"El promedio de las restas es: {promedio}");
    }
    static void AlmacenamientoEmpresa()
    {
        int[] A = new int[17];
        int[] B = new int[17];
        int[] C = new int[17]; 

        Console.WriteLine("Ingrese los 17 numeros enteros que representan la cantidad de cada producto en el inventario");
        for (int i = 0; i < 17; i++)
        {
            Console.Write($"Ingrese la cantidad del producto {i + 1}: ");
            A[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Ingrese los 17 numeros enteros que representan la cantidad de pedidos de cada producto");
        for (int i = 0; i < 17; i++)
        {
            Console.Write($"Ingrese la cantidad de pedidos del producto {i + 1}: ");
            B[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 17; i++)
        {
            if(A[i] == B[i])
            {
                C[i] = A[i];
            }
            else if(B[i] > A[i])
            {
                C[i] = 2 * (B[i] - A[i]);
            }
            else
            {
                C[i] = B[i];
            }
           
        }
        Console.WriteLine("\tResumen de inventario y reposicion de productos");
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("Producto\tInventario (A)\tPedidos (B)\tReposicion (C)");
        Console.WriteLine("-------------------------------------------------------------");
        for (int i = 0; i < 17; i++)
        {
            Console.WriteLine($"{i + 1}\t\t{A[i]}\t\t{B[i]}\t\t{C[i]}");
        }
    }

 static void TorneoDeFutbol()
    {
        int equipos = 10;
        int columnas = 5;
        

        int[,] torneo = new int[equipos, columnas];

        Console.WriteLine("Ingrese los resultados de los partidos del torneo de futbol");
        for(int i = 0; i < equipos; i++)
        {
            Console.WriteLine($"Equipos {i + 1}");
            
            Console.Write("Partidos jugados: ");
            torneo[i, 0] = int.Parse(Console.ReadLine());

            Console.Write("Partidos ganados: ");
            torneo[i, 1] = int.Parse(Console.ReadLine());

            Console.Write("Puntos obtenidos: ");
            torneo[i, 2] = int.Parse(Console.ReadLine());

            torneo[i, 3] = torneo[i, 2] - (torneo[i, 1] * 3);

            torneo[i, 4] = torneo[i, 0] - torneo[i, 1] - torneo[i, 3];
        }
        Console.WriteLine(" \tResumen del torneo de futbol");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Equipos\tPJ\tPG\tPun\tPE\tPP");
        Console.WriteLine("--------------------------------------------");
        for (int i = 0; i < equipos; i++)
        {
            Console.WriteLine($" {i + 1}\t{torneo[i,0]}\t{torneo[i,1]}\t{torneo[i,2]}\t{torneo[i,3]}\t{torneo[i,4]}");
        }

    }
}