using System;

class PiedraPapelTijera
{
    static void Main(string[] args)
    {
        string jugador1, jugador2;
        string continuar;

        do
        {
            Console.Write("Jugador 1, ingrese su elección (Piedra, Papel o Tijera): ");
            jugador1 = Console.ReadLine().ToLower();

          
            Console.Write("Jugador 2, ingrese su elección (Piedra, Papel o Tijera): ");
            jugador2 = Console.ReadLine().ToLower();

   
            if (jugador1 == jugador2)
            {
                Console.WriteLine("Resultado: Empate.");
            }
            else if (jugador1 == "piedra" && jugador2 == "tijera" ||
                     jugador1 == "papel" && jugador2 == "piedra" ||
                     jugador1 == "tijera" && jugador2 == "papel")
            {
                Console.WriteLine($"Resultado: Jugador 1 gana. {(jugador1)} vence a {(jugador2)}.");
            }
            else if (jugador2 == "piedra" && jugador1 == "tijera" ||
                     jugador2 == "papel" && jugador1 == "piedra" ||
                     jugador2 == "tijera" && jugador1 == "papel")
            {
                Console.WriteLine($"Resultado: Jugador 2 gana. {(jugador2)} vence a {(jugador1)}.");
            }
            else
            {
                Console.WriteLine("Una o ambas elecciones son inválidas. Por favor, elige entre Piedra, Papel o Tijera.");
            }

        
            Console.Write("¿Quieren jugar otra ronda? (sí/no): ");
            continuar = Console.ReadLine().ToLower();

        } while (continuar == "sí" || continuar == "si");

        Console.WriteLine("Fin del juego. ¡Gracias por jugar!");
    }
}
