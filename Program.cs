using System;
using Colas_enlazadas;

public class Program
{
    public static void Main(string[] args)
    {
        Colaenlazada Cola = new Colaenlazada();
        int opcion;
        do
        {
            Console.WriteLine("1. Encolar");
            Console.WriteLine("2. Desencolar");
            Console.WriteLine("3. Mostrar");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Ingrese una opcion: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese un dato: ");
                    string dato = Console.ReadLine();
                    Cola.Encolar(dato);
                    break;
                case 2:
                    string d = Cola.Desencolar();
                    if (d != null)
                    {
                        Console.WriteLine("Dato desencolado: " + d);
                    }
                    else
                    {
                        Console.WriteLine("La cola esta vacia");
                    }
                    break;
                case 3:
                    Cola.Mostrar();
                    break;
                case 4:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        } while (opcion != 4);
    }
}
