class Juego
{
        public static string palabraAdivinar {get;set;}
        public static List<char> letrasAdivinadas {get;set;}
        public static List<char> palabraJugada {get;set;}
        public static List<char> letrasErradas {get;set;}

    public static void crearRandom()
    {
        int num;
        Random r = new Random();
        num = r.Next(0, CargarPalabras.listaPalabras.Count);
        palabraAdivinar = CargarPalabras.listaPalabras[num];
    }
    public static void ingresarLetra(char letra){
         
        if (palabraAdivinar.Contains(letra))
        {
            letrasAdivinadas.Add(letra);
        }
        else
        {
            letrasErradas.Add(letra);
        }

        for (int i = 0; i < palabraAdivinar.Length; i++)
        {
            if (letrasAdivinadas.Contains(palabraAdivinar[i]))
            {
                palabraJugada.Add(palabraAdivinar[i]);
            }
            else
            {
                palabraJugada.Add('_');
            }

        }
    }
    public static bool ingresarPalabra(string palabra){
      bool adivino = false;
        if (palabra == palabraAdivinar)
        {
            adivino = true;
        }
        return adivino;
    }
}