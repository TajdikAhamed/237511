using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonemus
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic a = 2;

            Console.WriteLine(a);
            a = "asd";

            Console.WriteLine(a);

            var persons = new[]
            {
                new {Name="Tajdik",Age = 20, height = 5.11,Weight= 80},
                new {Name="sadik",Age = 21, height = 5.8,Weight= 90},
                new {Name="emon",Age = 15, height = 5.1,Weight= 50},
            };

            foreach (var person in persons)
            {

                Console.WriteLine("Name "+person.Name+" age "+person.Age+" height "+person.height+" weight "+person.Weight);
            }

            Console.ReadKey();
        }
    }
}
