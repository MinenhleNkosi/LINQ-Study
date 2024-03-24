namespace LINQ101
{
    /// <summary>
    /// Filtering is an essential operation when working with collections of data. 
    /// LINQ provides several methods for filtering data, such as Where, Take, Skip, and TakeWhile.
    /// </summary>
    public class Filtering
    {
        /// <summary>
        /// Where: The Where method is used to filter a collection based on a specified condition. 
        /// It returns a new collection containing only the elements that satisfy the given condition.
        /// </summary>
        public void WhereMethod()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);
        }


        /// <summary>
        /// Take: The Take method returns a specified number of elements from the start of a collection.
        /// </summary>
        public void TakeMethod()
        {
            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var firstThreeNumbers = numbers.Take(3);
            
        }


        /// <summary>
        /// Skip: The Skip method is used to bypass a specified number of elements in a collection and return the remaining elements.
        /// </summary>
        public void SkipMethod()
        {
            var numbers = new List<int> { 1, 9, 2, 8, 3, 7, 4, 6, 5 };
            var numbersAfterFirstThree = numbers.Skip(3);
        }


        /// <summary>
        /// TakeWhile: The TakeWhile method returns elements from a collection as long as a specified condition is true. 
        /// Once the condition is false, the method stops returning elements.
        /// </summary>
        public void TakeWhileMethod()
        {
            var numbers = new List<int> { 10, 1, 9, 2, 8, 3, 7, 4, 6, 5 };
            var numbersUnitFirstEven = numbers.TakeWhile(n => n % 2 != 0);
        }

        /// <summary>
        /// LINQ allows you to filter data using multiple conditions and compound operators such as && (AND) and || (OR). 
        /// To filter data based on multiple conditions, you can chain multiple Where clauses or use compound operators within a single Where clause.
        /// </summary>
        public void FilterWithMultipleConditionsMethod()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Using multiple Where clauses
            var evenNumbersGreaterThanFive = numbers.Where(n => n % 2 == 0).Where(n => n > 5);

            // Using compound operators
            var evenNumbersGreaterThanFive2 = numbers.Where(n => n % 2 == 0 && n > 5);
        }
    }
}