namespace JuegoAhorcados
{
    class Palabra
    {
        private string[] palabras = { "computadora", "tecnologia", "desarrollo", "software", "programacion", "algoritmo", "framework", "javascript", "base de datos", "inteligencia" };
        private string palabra_secreta;
        private char[] letras_adivinadas;

        public Palabra()
        {
            Random random = new Random();
            palabra_secreta = palabras[random.Next(0, palabras.Length)];
            letras_adivinadas = new char[palabra_secreta.Length];
            MostrarAlgunasLetras();
        }

        private void MostrarAlgunasLetras()
        {
            Random random = new Random();
            int mostrado = 0;
            while (mostrado < 2) 
            {
                int indice = random.Next(0, palabra_secreta.Length);
                if (letras_adivinadas[indice] == '\0')
                {
                    letras_adivinadas[indice] = palabra_secreta[indice];
                    mostrado++;
                }
            }
        }

        public bool AdivinarLetra(char letra)
        {
            bool letra_adivinada = false;
            for (int i = 0; i < palabra_secreta.Length; i++)
            {
                if (palabra_secreta[i] == letra)
                {
                    letras_adivinadas[i] = letra; 
                    letra_adivinada = true;
                }
            }
            return letra_adivinada;
        }

        public void MostrarPalabra()
        {
            for (int i = 0; i < palabra_secreta.Length; i++)
            {
                if (letras_adivinadas[i] != '\0')
                {
                    Console.Write(letras_adivinadas[i] + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }
            Console.WriteLine();
        }

        public bool PalabraCompleta()
        {
            foreach (char letra in letras_adivinadas)
            {
                if (letra == '\0')
                {
                    return false;
                }
            }
            return true;
        }

        public string PalabraSecreta
        {
            get { return palabra_secreta; }
        }
    }
}
