namespace Programa02;

class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("--- BLOQUE 1: NÚMEROS ENTEROS ---");

            // Declaración de un entero
            int edad = 28;
            int cantidad = 100;            
            int añoDeNacimiento = 1993; 
            int numeroNegativo = -5;
            int añosCursando = 3;  

            Console.WriteLine("1. TIPO ENTERO (int):");
            Console.WriteLine("   Para números sin decimales, como edad o cantidad.");
            Console.WriteLine("   Valor guardado: " + edad);
            Console.WriteLine("   Valor guardado: " + cantidad);
            Console.WriteLine("   Valor guardado: " + añoDeNacimiento);
            Console.WriteLine("   Valor guardado: " + numeroNegativo);
            Console.WriteLine("   Valor guardado: " + añosCursando);    


            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}