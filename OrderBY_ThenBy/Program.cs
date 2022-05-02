using OrderBY_ThenBy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderBY_ThenBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://csharp.net-tutorials.com/pt/439/linq/organizando-dados-os-metodos-orderby-thenby/

            List<User> li = new List<User>
            {

                new User() { Name = "John Doe", Mail = "john@doe.com", Age = 42 },
                new User() { Name = "Jane Doe", Mail = "jane@doe.com", Age = 42 },
                new User() { Name = "Joe Doe", Mail = "joe@doe.com", Age = 8 },
                new User() { Name = "Jenna Doe", Mail = "another@doe.com", Age = 8 },

            };

            Console.WriteLine(" " + String.Join(" ", li));
            Console.WriteLine();

            li = li.OrderBy(x => x.Age).ToList();

            Console.WriteLine(" " + String.Join(" ", li));

            li = li.OrderBy(x => x.Age).ThenBy(x => x.Name).ToList();


            Console.WriteLine(" " + String.Join(" ", li));



        }






    }
}
