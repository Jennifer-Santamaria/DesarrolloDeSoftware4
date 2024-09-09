using System;

class Calificaciones
{
    static void Main(string[] args)
    {
        // Pedir al usuario que ingrese el promedio numérico del estudiante
        Console.Write("Ingresa el promedio numérico del estudiante (0-100): ");
        int promedio = Convert.ToInt32(Console.ReadLine());

        // Validar que el promedio esté dentro del rango válido (0-100)
        if (promedio < 0 || promedio > 100)
        {
            Console.WriteLine("Por favor ingresa un promedio válido entre 0 y 100.");
        }
        else
        {
            // Determinar la calificación cualitativa basada en el promedio
            if (promedio >= 90 && promedio <= 100)
            {
                Console.WriteLine("Calificación: Aprobado con Sobresaliente");
            }
            else if (promedio >= 80 && promedio <= 89)
            {
                Console.WriteLine("Calificación: Aprobado con Distinción");
            }
            else if (promedio >= 70 && promedio <= 79)
            {
                Console.WriteLine("Calificación: Aprobado");
            }
            else
            {
                Console.WriteLine("Calificación: Reprobado");
            }
        }
    }
}
