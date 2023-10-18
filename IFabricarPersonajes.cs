namespace AbstractFactory
{
    public interface IFabricarPersonajes
    {
        IJugador CrearJugador();
        IArma CrearArma();
    }
}
