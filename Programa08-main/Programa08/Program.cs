namespace Programa08;

class Program
{
    static void Main(string[] args)
    {
        // inferencia de tipo con var (sin estructuras de control)
        var x = 10;                       
        var y = 3.14;                     
        var mensaje = "Hola sin control"; 

        // colecciones sin bucles explícitos
        var lista = new System.Collections.Generic.List<int> { 1, 2, 3 };
        var suma = lista[0] + lista[1] + lista[2];

        Console.WriteLine($"x = {x}, y = {y}, mensaje = {mensaje}");
        Console.WriteLine($"suma de lista = {suma}");

        // cálculo sin estructura de control
        var total = x + (int)y + suma;
        Console.WriteLine($"total = {total}");

        // Ejemplo 1
        var a = 20;                       
        var b = 2.71;                    
        var texto = "Hola ejemplo 1";     

        var lista1 = new System.Collections.Generic.List<int> { 4, 5, 6 };
        var suma1 = lista1[0] + lista1[1] + lista1[2];

        Console.WriteLine($"a = {a}, b = {b}, texto = {texto}");
        Console.WriteLine($"suma de lista1 = {suma1}");

        var total1 = a + (int)b + suma1;
        Console.WriteLine($"total1 = {total1}");

        // Ejemplo 2
        var p = 15;                      
        var q = 1.41;                     
        var frase = "Hola ejemplo 2";     

        var lista2 = new System.Collections.Generic.List<int> { 7, 8, 9 };
        var suma2 = lista2[0] + lista2[1] + lista2[2];

        Console.WriteLine($"p = {p}, q = {q}, frase = {frase}");
        Console.WriteLine($"suma de lista2 = {suma2}");

        var total2 = p + (int)q + suma2;
        Console.WriteLine($"total2 = {total2}");

        // Ejemplo 3
        var m = 25;                       
        var n = 0.99;                     
        var saludo = "Hola ejemplo 3";   

        var lista3 = new System.Collections.Generic.List<int> { 10, 11, 12 };
        var suma3 = lista3[0] + lista3[1] + lista3[2];

        Console.WriteLine($"m = {m}, n = {n}, saludo = {saludo}");
        Console.WriteLine($"suma de lista3 = {suma3}");

        var total3 = m + (int)n + suma3;
        Console.WriteLine($"total3 = {total3}");

        // Ejemplo 4
        var r = 30;                       
        var s = 4.67;                     
        var mensaje2 = "Hola ejemplo 4";   

        var lista4 = new System.Collections.Generic.List<int> { 13, 14, 15 };
        var suma4 = lista4[0] + lista4[1] + lista4[2];

        Console.WriteLine($"r = {r}, s = {s}, mensaje2 = {mensaje2}");
        Console.WriteLine($"suma de lista4 = {suma4}");

        var total4 = r + (int)s + suma4;
        Console.WriteLine($"total4 = {total4}");

        // Ejemplo 5
        var t = 35;                       
        var u = 6.28;                     
        var texto2 = "Hola ejemplo 5";    

        var lista5 = new System.Collections.Generic.List<int> { 16, 17, 18 };
        var suma5 = lista5[0] + lista5[1] + lista5[2];

        Console.WriteLine($"t = {t}, u = {u}, texto2 = {texto2}");
        Console.WriteLine($"suma de lista5 = {suma5}");

        var total5 = t + (int)u + suma5;
        Console.WriteLine($"total5 = {total5}");
    }
}
