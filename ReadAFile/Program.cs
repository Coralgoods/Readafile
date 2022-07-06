using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"/Users/eduardodiaz/Desktop/NameList.txt";

            List<string> lines = new List<string>(); 
            List<Person> people = new List<Person>();
            lines = File.ReadAllLines(filePath).ToList();



            //You don't really need it. 
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Person p = new Person(items[0], items[1], items[2]);
                people.Add(p); 
            }

            foreach(Person p in people)
            {
                Console.WriteLine(p); 
            }

            Console.ReadLine(); 

        }
    }
}
