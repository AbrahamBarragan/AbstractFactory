namespace AbstractFactory
{
    public class Guerrero : IJugador
    {
        public void MostrarInformacion()
        {
            Console.WriteLine("Jugador tipo guerrero");
        }
    }

    public class Mago : IJugador
    {
        public void MostrarInformacion()
        {
            Console.WriteLine("Jugador tipo mago");
        }
    }

    public class Espada : IArma
    {
        public void TipoDeArma()
        {
            Console.WriteLine("Arma: Espada");
        }
    }

    public class Varita : IArma
    {
        public void TipoDeArma()
        {
            Console.WriteLine("Arma: Varita Mágica");
        }
    }
}
