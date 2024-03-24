using System.Collections.Generic;

namespace LINQ101
{
    /// <summary>
    /// Projection is a powerful technique in LINQ that allows you to transform or shape the data being queried. 
    /// It enables you to create new objects or select a subset of properties from the original data source 
    /// based on specific requirements.
    /// </summary>
    public class Projection
    {


        /// <summary>
        /// Select: The Select method is used for one-to-one mapping, where each element in the input sequence is 
        /// mapped to a single output element. It takes a delegate or lambda expression as an argument, which 
        /// defines the transformation to be applied to each element in the collection.
        /// </summary>
        public IEnumerable<int> SelectMethod()
        {
            Console.WriteLine("Select Method");
            List<int> numbers = new() { 1, 2, 3, 4,5 };

            //! Using Select to square each number
            var squaredNumbers = numbers
                .Select(square => square * square);

            foreach (var  number in squaredNumbers)
            {
                Console.WriteLine(number);
            }
            return squaredNumbers;
        }


        /// <summary>
        /// SelectMany: The SelectMany method is used for one-to-many mapping, where each element in the input 
        /// sequence is mapped to a collection of output elements. This is useful when you need to flatten 
        /// a hierarchical data structure into a single sequence of elements.
        /// </summary>
        public IEnumerable<char> SelectManyMethod()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Select Many Method");
            List<string> phrases = new() { "Hello World", "Wola Jetro", "Wola Bhasted", "LINQ is Great" };

            //! Using SelectMany to obtain a flat sequence of characters
            var allCharacters = phrases
                .SelectMany(phrase => phrase.ToCharArray());

            foreach (var character in allCharacters)
            {
                Console.WriteLine(character);
            }
            return allCharacters;
        }


        /// <summary>
        /// Transforming a list of objects.
        /// Consider a list of Person objects, and you want to create a new list of PersonInfo objects containing only the names and ages of each person.
        /// </summary>
        public IEnumerable<PersonInfo> ReallWorldExamplesUsingSelect()
        {
            List<Person> people = new()
            {
                new Person { Name = "John", Age = 30, Address = "123 Main St" },
                new Person { Name = "Jane", Age = 28, Address = "456 Oak St" },
                new Person { Name = "Jetro", Age = 12, Address = "122 Jetro St"},
            };

            var personInfo = people.Select(person => new PersonInfo()
            {
                Name = person.Name,
                Age = person.Age,
            });

            foreach (var person in personInfo)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
            return personInfo;
        }


        /// <summary>
        /// Flattening a list of orders with multiple order items using SelectMany
        /// </summary>
        public IEnumerable<OrderItems> RealWorldExamplesUsingSelectMany()
        {
            List<Order> orders = new()
            {
                new Order()
                {
                    OrderId = 1,
                    Items = new List<OrderItems>
                    {
                        new OrderItems
                        {
                            ProductId = 101,
                            Quantity = 2,
                        },

                        new OrderItems
                        {
                            ProductId = 102,
                            Quantity = 3,
                        }
                    }
                },

                new Order()
                {
                    OrderId = 2,
                    Items = new List<OrderItems>
                    {
                        new OrderItems
                        {
                            ProductId = 201,
                            Quantity = 4,
                        },

                        new OrderItems
                        {
                            ProductId = 202,
                            Quantity = 5,
                        }
                    }
                },
            };

            //! Flatten the list of orders into a single list of order items.
            var allOrderItems = orders.SelectMany(order => order.Items);

            foreach (var  order in allOrderItems) 
            {
                Console.WriteLine($"Product: {order.ProductId}, Quantity: {order.Quantity}");
            }
            return allOrderItems;
        }
    }
}