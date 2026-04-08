namespace Programa06;

class Program
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
            const string NOMBRE_APP = "Augusto";
            const string VERSION = "v1.0";
            const int EDAD_MINIMA = 18;

            Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Restricción: Prohibida la venta a menores de " + EDAD_MINIMA + " años.");
            
            // Intento de uso con constantes (sin estructuras de control)
            const int EDAD_CLIENTE = 20;
            const bool PUEDE_INGRESAR = EDAD_CLIENTE >= EDAD_MINIMA; // expresión booleana

            Console.WriteLine("\nVerificando cliente de " + EDAD_CLIENTE + " años...");
            Console.WriteLine("Edad mínima: " + EDAD_MINIMA);
            Console.WriteLine("Acceso permitido (valor bool constante): " + PUEDE_INGRESAR);

            // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
            Console.WriteLine("Constante VERSION = " + VERSION);

            // Ejemplos adicionales de uso de constantes
            const double PI = 3.14159;
            Console.WriteLine("Constante PI = " + PI);

            const string MENSAJE_BIENVENIDA = "Bienvenido al sistema";
            Console.WriteLine(MENSAJE_BIENVENIDA);

            const int MAX_USUARIOS = 100;
            Console.WriteLine("Máximo de usuarios: " + MAX_USUARIOS);

            const char SIMBOLO_MONEDA = '$';
            Console.WriteLine("Símbolo de moneda: " + SIMBOLO_MONEDA);

            const bool ES_PRODUCCION = true;
            Console.WriteLine("Es producción: " + ES_PRODUCCION);

            // Más intentos de uso con constantes (sin estructuras de control)
            const bool ES_ADULTO = EDAD_CLIENTE >= EDAD_MINIMA;
            Console.WriteLine("Es adulto: " + ES_ADULTO);

            const double AREA_CIRCULO = PI * 10 * 10;
            Console.WriteLine("Área del círculo: " + AREA_CIRCULO);

            const string SALUDO_COMPLETO = MENSAJE_BIENVENIDA + ", " + NOMBRE_APP;
            Console.WriteLine(SALUDO_COMPLETO);

            const int USUARIOS_DISPONIBLES = MAX_USUARIOS - 10;
            Console.WriteLine("Usuarios disponibles: " + USUARIOS_DISPONIBLES);

            const bool MONEDA_VALIDA = SIMBOLO_MONEDA == '$';
            Console.WriteLine("Moneda válida: " + MONEDA_VALIDA);

            Console.ReadLine();

    }
}
