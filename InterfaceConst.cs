namespace advanced01
{
    public interface printable
    {
        void print();
    }
    internal class InterfaceConst<T> where T : printable
    {
        void PrintItem(T item) 
        {
            item.print();
        }

    }
}
