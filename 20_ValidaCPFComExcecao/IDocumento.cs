namespace _20_ValidaCPFComExcecao
{
    public interface IDocumento
    {
        string Numero { get; }
        bool Validar();
    }
}
