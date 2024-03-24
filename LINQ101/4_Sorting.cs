namespace LINQ101
{
    /// <summary>
    /// Sorting is an essential operation when working with data, as it allows you to organize and 
    /// present information in a meaningful order. LINQ provides a set of powerful methods 
    /// for sorting data based on specific criteria.
    /// </summary>
    public class Sorting
    {
        List<Employee> employees = new()
        {
            new Employee
            {
                Name = "Jetro",
                Age = 30,
                Salary = 5000,
            },
            new Employee
            {
                Name = "Mini",
                Age = 23,
                Salary = 200,
            },
            new Employee
            {
                Name = "Mxo",
                Age = 25,
                Salary = 50000,
            }
        };


        /// <summary>
        /// OrderBy: This method is used to sort a collection in ascending order based on a specified key. 
        /// It takes a delegate or lambda expression as an argument, which defines the key selector function.
        /// </summary>
        public void OrderByMethod()
        {
            //! Sort employees by salary in ascending order.
            var sort = employees
                .OrderBy(e => e.Salary);

            foreach (var employee in sort)
            {
                Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}, Salary: {employee.Salary}");
            }
        }


        /// <summary>
        /// ThenBy: This method is used in conjunction with OrderBy or OrderByDescending to apply secondary 
        /// sorting criteria when the primary sorting key has duplicate values.
        /// </summary>
        public void ThenByMethod()
        {
            //! Sort employees by salary in ascending order and then by age.
            var sort = employees
                .OrderBy(e => e.Salary)
                .ThenBy(e => e.Age);

            foreach (var employee in sort)
            {
                Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}, Salary: {employee.Salary}");
            }
        }


        /// <summary>
        /// OrderByDescending: This method is used to sort a collection in descending order based on a specified key. 
        /// Like OrderBy, it takes a delegate or lambda expression as an argument.
        /// </summary>
        public void OrderByDescendingMethod()
        {
            //! Sort employees by salary in descending order and then by age.
            var sort = employees
                .OrderByDescending(e => e.Salary)
                .ThenBy(e => e.Age);

            foreach (var employee in sort)
            {
                Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}, Salary: {employee.Salary}");
            }
        }


        /// <summary>
        /// ThenByDescending: This method is used in conjunction with OrderBy or OrderByDescending to apply 
        /// secondary sorting criteria in descending order.
        /// </summary>
        public void ThenByDescendingMethod()
        {
            //! Sort employees by salary in ascending order and then by age in descending order
            var sortedEmployees = employees
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.Age);

            foreach (var employee in sortedEmployees)
            {
                Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}, Salary: {employee.Salary}");
            }
        }


        public void MixtureSortingMethods()
        {
            //! Here we mix and blend the above methods and use other useful sortng methods.
        }
    }
}