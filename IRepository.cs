namespace advanced01
{
    internal interface IRepository<T>
    {
        T Add(T item);
        T Get(int id);


    }
}
