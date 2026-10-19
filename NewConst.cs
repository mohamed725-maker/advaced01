namespace advanced01
{
    internal class NewConst<T>where T : new()
    {
        public T create()
        {
            return new T();
            
        }

    }
}
