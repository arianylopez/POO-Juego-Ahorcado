namespace JuegoAhorcados
{
    class JuegoAhorcado
    {
        private Palabra palabra;
        private Jugador jugador;
        private bool otra_partida;

        public JuegoAhorcado()
        {
            otra_partida = true;
        }

        public void IniciarJuego()
        {
            while (otra_partida)
            {
                palabra = new Palabra();
                jugador = new Jugador();

                Console.WriteLine("¡Juego del ahorcado!");
                Console.WriteLine("Tienes " + jugador.Vidas + " intentos para adivinar la palabra.");

                while (jugador.Vidas > 0 && !palabra.PalabraCompleta())
                {
                    MostrarEstado();
                    char letra = SolicitarLetra();
                    if (char.IsUpper(letra)) 
                    {
                        Console.WriteLine("Error: Ingresa letras minúsculas.");
                        continue; 
                    }

                    if (!palabra.AdivinarLetra(letra)) 
                    {
                        jugador.PerderVida();
                        jugador.AgregarLetraIncorrecta(letra); 
                    }
                }

                MostrarResultadoFinal();
                otra_partida = PreguntarOtraPartida();
            }
        }

        private void MostrarEstado()
        {
            Console.WriteLine("\nVidas Restantes: " + jugador.Vidas);
            Console.WriteLine("Letras Incorrectas: " + string.Join(" ", jugador.LetrasIncorrectas));
            Console.WriteLine("Palabra: ");
            palabra.MostrarPalabra();
        }

        private char SolicitarLetra()
        {
            Console.Write("Ingresa una letra: ");
            return Console.ReadLine()[0];
        }

        private void MostrarResultadoFinal()
        {
            if (jugador.Vidas == 0)
            {
                Console.WriteLine("\nTe quedaste sin vidas :(");
                Console.WriteLine("La palabra era: " + palabra.PalabraSecreta);
            }
            else
            {
                Console.WriteLine("\nAdivinaste la palabra :D : " + palabra.PalabraSecreta);
            }
        }

        private bool PreguntarOtraPartida()
        {
            Console.WriteLine("\n1. Seguir jugando");
            Console.WriteLine("2. Salir del juego");
            Console.Write("Elige una opción (1 o 2): ");
            string opcion = Console.ReadLine();
            if (opcion == "2")
            {
                Console.WriteLine("Gracias por jugar :)!");
                return false;
            }
            Console.WriteLine("Nueva partida!!!");
            return true;
        }
    }
}
