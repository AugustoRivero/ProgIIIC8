using System.Numerics;

namespace Program01;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("--- SISTEMA DE REGISTRO DE USUARIO ---");

            // 1. Entrada de Texto (Simple)
            Console.Write("Por favor, ingresa tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Por favor, Ingrese su apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Por favor, ingrese su pais de nacimiento: ");
            string pais = Console.ReadLine();
            Console.WriteLine("Por favor , ingrese su provincia : ");
            string provincia =  Console.ReadLine();
            Console.WriteLine("Por favor, ingrese su ciudad de residencia: ");
            string ciudad = Console.ReadLine();
             Console.WriteLine("Por favor, ingrese su calle : ");
            string calle = Console.ReadLine();


            // 2. Entrada de Números (Requiere Conversión)
            Console.Write("Ingresa tu edad: ");
            string edadTexto = Console.ReadLine();
            int edad = int.Parse(edadTexto); // Convertimos el texto a número entero
            Console.Write("Ingresa tu año de nacimiento: ");
            string añoNacimientoTexto = Console.ReadLine();
            int añoNacimiento = int.Parse(añoNacimientoTexto); 
             Console.Write("Ingresa tu numero de telefono: ");
            string numeroTelefonoTexto = Console.ReadLine();
            BigInteger numeroTelefono = BigInteger.Parse(numeroTelefonoTexto); 
             Console.Write("Ingresa tu numero de documento: ");
            string numeroDocumentoTexto = Console.ReadLine();
            int numeroDocumento = int.Parse(numeroDocumentoTexto); 
             Console.Write("Ingresa tu codigo postal: ");
            string codigoPostalTexto = Console.ReadLine();  
            int codigoPostal = int.Parse(codigoPostalTexto); 

            // 3. Entrada de Decimales (Precios o Medidas)
            Console.Write("Ingresa tu estatura (ejemplo: 1,75): ");
            double estatura = double.Parse(Console.ReadLine()); // Conversión directa en una línea
            Console.Write("Ingresa tu peso (ejemplo: 70,5): ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Ingresa tu salario mensual (ejemplo: 1500,50): ");
            double salarioMensual = double.Parse(Console.ReadLine());
            Console.Write("Ingresa tu numero de cuenta bancaria (ejemplo: 1234567890): ");
            double numeroCuentaBancaria = double.Parse(Console.ReadLine());
            Console.Write("Ingresa tu altura en centimetros (ejemplo: 175,5): ");
            double altura = double.Parse(Console.ReadLine());


            // 4. Mostrar los resultados procesados
            Console.WriteLine("\n--- PERFIL CREADO ---");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("País de Nacimiento: " + pais);
            Console.WriteLine("Provincia: " + provincia);
            Console.WriteLine("Ciudad de Residencia: " + ciudad);
            Console.WriteLine("Calle: " + calle);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Año de Nacimiento: " + añoNacimiento);
            Console.WriteLine("Número de Teléfono: " + numeroTelefono);
            Console.WriteLine("Número de Documento: " + numeroDocumento);
            Console.WriteLine("Código Postal: " + codigoPostal);   
            Console.WriteLine("Edad el próximo año: " + (edad + 1)); // Operación matemática
            Console.WriteLine("Estatura: " + estatura + " metros");
            Console.WriteLine("Peso: " + peso + " kg");
            Console.WriteLine("Salario Mensual: $" + salarioMensual);
            Console.WriteLine("Número de Cuenta Bancaria: " + numeroCuentaBancaria);
            Console.WriteLine("Altura en centímetros: " + altura + " cm");
 
                    


            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
    }
}
