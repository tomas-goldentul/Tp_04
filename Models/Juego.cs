class Juego
{
    public static string palabraAdivinar { get; set; }
    public static List<char> letrasAdivinadas { get; set; } = new List<char>();
    public static List<char> palabraJugada { get; set; } = new List<char>();
    public static List<char> letrasErradas { get; set; } = new List<char>();

    public static void crearRandom()
    {
        int num;
        Random r = new Random();
        num = r.Next(0, CargarPalabras.listaPalabras.Count);
        palabraAdivinar = CargarPalabras.listaPalabras[num];
    }
    public static bool ingresarLetra(char letra)
    {
        bool finalizo = false;
        palabraJugada.Clear();
        if (palabraAdivinar.Contains(letra))
        {
            letrasAdivinadas.Add(letra);
        }
        else if(!letrasErradas.Contains(letra))
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
        if (!palabraJugada.Contains('_'))
        {
            finalizo = true;
        }
        return finalizo;
    }
    public static bool ingresarPalabra(string palabra)
    {
        bool adivino = false;
        if (palabra == palabraAdivinar)
        {
            adivino = true;
        }
        return adivino;
    }
}