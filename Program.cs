namespace C__Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1

            /*A generic class is a class that works with different data types using type parameters

            Why use generics 
            1.Code reusability
            2.Type safety
            3.Reduce code duplication  */


            #endregion

            #region question 2

            Container<int> c = new Container<int>();

            c.Add(10);

            Console.WriteLine(c.Get());

            #endregion







        }
    }
}
