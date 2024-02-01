namespace AplicacionEncuenta.Servicios
{
    public interface IEncuestaResultado
    {
        void AgregarVoto(Deporte deporte);
        SortedDictionary<Deporte, int> GetResultadoVoto();

    }
}
