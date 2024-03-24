namespace LINQ101
{

    /// <summary>
    /// Grouping is a powerful operation that allows you to organize data into groups based on a specified key. 
    /// This can be useful when you need to analyze or process data in a more structured way, 
    /// such as aggregating values within each group.
    /// </summary>
    public class Grouping
    {
        /// <summary>
        /// GroupBy: The GroupBy method is used to group elements of a collection based on a specified key. 
        /// It takes a delegate or lambda expression as an argument, which defines the key selector function. 
        /// The method returns an IEnumerable<IGrouping<TKey, TElement>>, where each IGrouping object 
        /// contains a key and a collection of elements that share the same key
        /// </summary>
        /// 


        List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "John", Age = 30, Department = "HR" },
                new Employee { Name = "Jane", Age = 28, Department = "HR" },
                new Employee { Name = "Bob", Age = 35, Department = "IT" },
            };

        public void GroupByMethod()
        {
            var groupedEmployees = employees.GroupBy(e => e.Department);

            foreach (var group in groupedEmployees)
            {
                Console.WriteLine($"Department: {group.Key}");
                foreach (var employee in group)
                {
                    Console.WriteLine($"  Name: {employee.Name}, Age: {employee.Age}");
                }
            }
        }


        /// <summary>
        /// ToLookup: The ToLookup method is similar to GroupBy, but it returns an ILookup<TKey, TElement> instead of an IEnumerable<IGrouping<TKey, TElement>>. 
        /// The main difference is that ILookup is optimized for multiple lookups, as it stores the grouped data in a dictionary-like structure.
        /// </summary>
        public void ToLookupMethod()
        {
            var employeeLookup = employees.ToLookup(e => e.Department);

            foreach (var group in employeeLookup)
            {
                Console.WriteLine($"Department: {group.Key}");
                foreach (var employee in group)
                {
                    Console.WriteLine($"  Name: {employee.Name}, Age: {employee.Age}");
                }
            }
        }
    }
}