using System;

class AdivinaElNumero
{
    static void Main(string[] args)
    {
       
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101); 
        int intento;
        int contadorIntentos = 0;

        Console.WriteLine("La computadora ha generado un número aleatorio entre 1 y 100.");

       
        do
        {
            Console.Write("Ingrese su suposición: ");
            intento = Convert.ToInt32(Console.ReadLine());
            contadorIntentos++;

            if (intento < numeroAleatorio)
            {
                Console.WriteLine("Demasiado bajo. Inténtalo de nuevo.");
            }
            else if (intento > numeroAleatorio)
            {
                Console.WriteLine("Demasiado alto. Inténtalo de nuevo.");
            }
            else
            {
                Console.WriteLine($"¡Correcto! El número era {numeroAleatorio}. Lo adivinaste en {contadorIntentos} intentos.");
            }

        } while (intento != numeroAleatorio);  

        Console.WriteLine("¡Gracias por jugar!");
    }
}
