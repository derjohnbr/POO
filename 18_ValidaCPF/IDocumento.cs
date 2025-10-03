namespace ValidadorCPF
{
    public interface IDocumento
    {
        string Numero { get; }
        bool Validar();
    }
}
