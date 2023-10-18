namespace AbstractFactory
{
    public class FabricarGuerrero : IFabricarPersonajes
    {
        public IJugador CrearJugador()
        {
            return new Guerrero();
        }

        public IArma CrearArma()
        {
            return new Espada();
        }
    }
}
