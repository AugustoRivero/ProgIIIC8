namespace Programa03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 2: NÚMEROS CON DECIMALES ---");

            // Estatura (double)
            double estatura = 1.75;
            Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
            Console.WriteLine("   Valor guardado: " + estatura + " metros");

            // Dinero (decimal) - Recuerda la 'm' al final
            decimal precioProducto = 199.99m;
            Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
            Console.WriteLine("   ¡Obligatorio para dinero! Usa la 'm'.");
            Console.WriteLine("   Valor guardado: $" + precioProducto);

            // peso en kg
            double peso = 70.5;
            Console.WriteLine("\n4. OTRO EJEMPLO CON double:");
            Console.WriteLine("   Peso: " + peso + " kg");  

            //temperatura
            double temperatura = 36.6;
            Console.WriteLine("\n5. OTRO EJEMPLO CON double:");
            Console.WriteLine("   Temperatura corporal: " + temperatura + " °C");   

            // velocidad          
            double velocidad = 120.5;
            Console.WriteLine("\n6. OTRO EJEMPLO CON double:");
            Console.WriteLine("   Velocidad del auto: " + velocidad + " km/h");

            //nota de un estudiante
            double nota = 8.75;
            Console.WriteLine("\n7. OTRO EJEMPLO CON double:");
            Console.WriteLine("   Nota del estudiante: " + nota);   

            // porcentaje de descuento
            double descuento = 15.5;
            Console.WriteLine("\n8. OTRO EJEMPLO CON double:");
            Console.WriteLine("   Porcentaje de descuento: " + descuento + " %");
            


            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}
