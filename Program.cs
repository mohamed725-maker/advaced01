

namespace advanced01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  q1
            //A generic class is a class that uses a type parameter (T) instead of data type
            //using generic for Code Reusability ,Type Safety and Reduce Code Duplication

            #endregion

            #region q3
            //allow a generic class to work with more than one data type


            #endregion

            #region q4
            //A generic method is a method that uses type parameters to work with different data types

            void Swap<T>(ref T a, ref T b)
            {
                T temp = a;

                a = b;

                b = temp;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }


            #endregion

            #region q5
            T FindMax<T>(T a, T b) where T : IComparable<T>
            {

                if (a.CompareTo(b) > 0)
                {
                    return a;

                }
                return b;

            }

            #endregion

            #region q6
            //A generic interface defines a contract using a type parameter

            #endregion

            #region q7

            //The struct constraint restricts the type parameter to value type


            #endregion

            #region q8
            //The class constraint restricts the type parameter to reference type

            #endregion

            #region q9
            // new() constraint requires a type to have a public parameterless constructor
            #endregion

            #region q10

            //An interface constraint requires the type parameter to implement a specific interface

            #endregion

            #region q11
            //A base class constraint requires the type parameter to be the specified base class or inherit from it
            #endregion

            #region q13
            //The default keyword returns the default value of a type
            #endregion

            #region q14
            T SafeList<T>(T index, T n) where T : IComparable<T>
            {
                if (index.CompareTo(n) > 0)
                {
                    return index;

                }
                return default(T)!;
            }
            #endregion

            #region q15
            // Covariance allows a generic interface of a derived type to be used where a generic interface of a base type is expected
            // The out keyword allows the type parameter to be used in output

            #endregion

            #region q16
            //Contravariance allows a generic interface of a base type to be used where a generic interface of a derived type is expected
            //The in keyword allows the type parameter to be used in input
            #endregion

            #region q17

            //Covariance (out): Allows conversion from a derived type to a base type. It is used for output
            //Contravariance (in): Allows conversion from a base type to a derived type. It is used for input

            #endregion

            #region q18
            //Each constructed generic type has its own separate static members
            #endregion

            #region 19

            //A generic class can inherit from another generic class by passing a type parameter to the base class
            #endregion

        }
    }
}
