using System.Linq;
using System.Collections.Generic;

namespace LINQ101
{
    public class Program
    {
        static void Main(string[] args)
        {
            //! Defining Instances
            Deferred_Execution def = new();
            Projection projection = new();

            Console.WriteLine("...............................Start of Deferred Execution..............................");
            def.LazyEvaluation();
            Console.WriteLine("...............................End of Deferred Execution................................");
            Console.WriteLine("\n\n");

            Console.WriteLine("...............................Start of Projection..............................");
            IEnumerable<int> selectResults = projection.SelectMethod();
            IEnumerable<char> selectManyResults = projection.SelectManyMethod();
            Console.WriteLine("...............................End of Projection..............................");
            Console.WriteLine("\n\n");


            Console.WriteLine("...............................Start of Projection on Real World Examples..............................");
            IEnumerable<PersonInfo> results = projection.ReallWorldExamplesUsingSelect();
            IEnumerable<OrderItems> results2 = projection.RealWorldExamplesUsingSelectMany();
            Console.WriteLine("...............................End of Projection on Real World Examples..............................");
            Console.WriteLine("\n\n");


        }
    }
}
