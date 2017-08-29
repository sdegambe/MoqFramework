using System;
using System.Collections.Generic;

namespace MoqFramework
{
    public class Program
    {
        private static IList<Person> Persons { get; set; }

        static void Main(string[] args)
        {
            Persons = new List<Person>();
        }

        public void Add()
        {
        }
    }
}
