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
            lines = File.ReadAllLines(filePath).ToList();
            //Above code will make a list with the info from the file. 
           

            //You don't really need the below.  
            List<Person> people = new List<Person>();
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
