namespace advanced01
{   
    #region q2
    public class Container<T>
    {
        public T Item = default;

        public void Add(T item)
        {
            Item = item;
            
        }
        public T Get()
        {
            return Item;
        }
    }
   

    #endregion
}
