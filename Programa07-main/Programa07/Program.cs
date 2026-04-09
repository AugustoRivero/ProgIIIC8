namespace Programa07;

class Program
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE CÁLCULO Y CONTROL ---
            const decimal TASA_IVA = 0.21m; // 21% fijo
            const bool MODO_PRUEBA = false; // Control de seguridad
            const char SIMBOLO_PESO = '$';
            const decimal DESCUENTO_MAXIMO = 0.15m; // 15% máximo descuento
            const decimal LIMITE_CREDITO = 5000.00m; // Límite de crédito en pesos
            const int DIAS_VENCIMIENTO = 30; // Días para vencimiento de factura
            const bool ENVIO_HABILITADO = true; // Control para habilitar envío
            const decimal TASA_INTERES = 0.05m; // 5% tasa de interés por mora

            Console.WriteLine("--- MÓDULO DE FACTURACIÓN ---");
            Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

            decimal precioBase = 1500.50m;
            decimal impuestoCalculado = precioBase * TASA_IVA;
            decimal total = precioBase + impuestoCalculado;

            Console.WriteLine("\nDetalle de la compra:");
            Console.WriteLine("Precio: " + SIMBOLO_PESO + precioBase);
            Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + impuestoCalculado);
            Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);

            Console.WriteLine("\nConstantes adicionales:");
            Console.WriteLine("Descuento máximo: " + (DESCUENTO_MAXIMO * 100) + "%");
            Console.WriteLine("Límite de crédito: " + SIMBOLO_PESO + LIMITE_CREDITO);
            Console.WriteLine("Días de vencimiento: " + DIAS_VENCIMIENTO);
            Console.WriteLine("Envío habilitado: " + ENVIO_HABILITADO);
            Console.WriteLine("Tasa de interés: " + (TASA_INTERES * 100) + "%");

            Console.ReadLine();

    }
}
