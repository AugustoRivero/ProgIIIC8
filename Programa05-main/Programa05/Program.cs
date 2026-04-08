namespace Programa05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 4: VALORES LÓGICOS (SÍ / NO) ---");

            // Booleano (bool) - Solo true o false
            bool cursoCompletado = true;

            Console.WriteLine("6. TIPO LÓGICO (bool):");
            Console.WriteLine("   Solo puede ser 'true' o 'false'.");
            Console.WriteLine("   ¿El curso está completado?: " + cursoCompletado);

            bool esMayorDeEdad = false;
            Console.WriteLine("   ¿Es mayor de edad?: " + esMayorDeEdad);   

            bool tieneDescuento = true;
            Console.WriteLine("   ¿Tiene descuento?: " + tieneDescuento);

            bool esFinDeSemana = false;
            Console.WriteLine("   ¿Es fin de semana?: " + esFinDeSemana);

            bool estaLloviendo = true;
            Console.WriteLine("   ¿Está lloviendo?: " + estaLloviendo);

            bool esEstudiante = true;     
            Console.WriteLine("   ¿Es estudiante?: " + esEstudiante);
            

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}
