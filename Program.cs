using AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        IFabricarPersonajes fabricaGuerrero = new FabricarGuerrero();
        IJugador jugador1 = fabricaGuerrero.CrearJugador();
        IArma arma1 = fabricaGuerrero.CrearArma();

        jugador1.MostrarInformacion();
        arma1.TipoDeArma();

        IFabricarPersonajes fabricaMago = new FabricarMago();
        IJugador jugador2 = fabricaMago.CrearJugador();
        IArma arma2 = fabricaMago.CrearArma();

        jugador2.MostrarInformacion();
        arma2.TipoDeArma();

        Console.ReadKey();
    }
}
