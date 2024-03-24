namespace LINQ101
{
    /// <summary>
    /// Deferred execution, also known as lazy evaluation, is a powerful feature 
    /// in LINQ that postpones the execution of a query until the results are actually needed. 
    /// This can lead to improved performance, as unnecessary computations are avoided, 
    /// and the query is only executed when absolutely required.
    /// </summary>
    public class Deferred_Execution
    {
        List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

        /// <summary>
        /// In this example, the evenNumbers query is defined to filter out even numbers from the numbers list. 
        /// However, the query is not executed immediately. After defining the query, more elements are added to the list. 
        /// When the foreach loop is executed, the evenNumbers query is finally evaluated, 
        /// taking into account the newly added elements as well. 
        /// </summary>
        public void LazyEvaluation()
        {
            //! Define the LINQ query but don't execute it yet.
            var evenNumbers = numbers.Where(even => even % 2 == 0);

            //! Add more elements to the list
            numbers.Add(10);
            numbers.Add(11);
            numbers.Add(12);
            numbers.Add(13);
            numbers.Add(14);

            //! Execute the Query by iterating/enumerating the results.
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}