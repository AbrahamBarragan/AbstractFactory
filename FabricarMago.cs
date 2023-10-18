namespace AbstractFactory
{
    public class FabricarMago : IFabricarPersonajes
    {
        public IJugador CrearJugador()
        {
            return new Mago();
        }

        public IArma CrearArma()
        {
            return new Varita();
        }
    }
}
