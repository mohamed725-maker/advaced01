namespace advanced01
{
    public class BaseClass
    {
        public void print()
        {
            Console.WriteLine("hello");
        }

    }

    public class dev <T>where T :BaseClass
    {
        public void printHello(T entity)
        {
            entity.print();

        }
    }
    public class Const <T> where T: BaseClass,printable
    {
        public void printItem(T entity) 
        {
            entity.print();


        }
    }


}
