using System;

class Program
{
    static void Main(string[] args)
    { 
        Console.Write("Ingresa el capital inicial: ");
        double cInicial = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa la tasa de intereses: ");
        double tInteres= Convert.ToDouble(Console.ReadLine())/100;

        Console.WriteLine("Ingresa la cantidad de años: ");
        int cantidadA = Convert.ToInt32(Console.ReadLine());

        double iCompuesto= CalcularInteresCompuesto(cInicial, tInteres, cantidadA);
        Console.WriteLine($"El interes compuesto  es de: {iCompuesto:C}");
    }

    // Método para calcular el interés compuesto
    static double CalcularInteresCompuesto(double cInicial, double tInteres, int cantidadA)
    {
        return cInicial * Math.Pow(1 + tInteres / 12, 12 * cantidadA);
    }
}

