using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            Console.WriteLine("Исходные данные:");
            foreach (var ls in classes)
            {
                foreach (var lsinclass in ls.Students)
                {
                    Console.Write(lsinclass);
                    Console.Write(", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            var allStudents = GetAllStudents(classes);
            Console.WriteLine("Исходные данные:");
            Console.WriteLine(string.Join(" ", allStudents));
            Console.ReadLine();
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            string[] ls = new string[9];
            string[] lsSort = new string[9];

            var query = from c in classes
                        select new { c.Students };
            int i = 0;
            foreach (var ss in query)
            {
               
                foreach (var sm in ss.Students)
                {
                    ls[i] = sm;

                    i++;
                }
            }

            lsSort = ls.OrderBy( elem => elem).ToArray();
            return lsSort;
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}