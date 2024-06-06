namespace ex05
{
    public interface IEntregable
    {
        void Entregar();
        void Devolver();
        bool IsEntregado();
        int CompareTo(object a);
    }
}
