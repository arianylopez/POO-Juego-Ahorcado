namespace JuegoAhorcados
{
    class Jugador
    {
        private int vidas;
        private char[] letras_incorrectas;
        private int cantidad;

        public Jugador()
        {
            vidas = 6; 
            letras_incorrectas = new char[20];
            cantidad = 0;
        }

        public void PerderVida()
        {
            vidas--;
        }

        public void AgregarLetraIncorrecta(char letra)
        {
            if (cantidad < letras_incorrectas.Length)
            {
                letras_incorrectas[cantidad] = letra;
                cantidad++;
            }
        }

        public int Vidas
        {
            get { return vidas; }
        }

        public char[] LetrasIncorrectas
        {
            get { return letras_incorrectas; }
        }
    }
}
