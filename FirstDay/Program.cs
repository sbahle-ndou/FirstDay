using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We are using Write not WriteLine
            Console.WriteLine("Enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
            Console.WriteLine("how old are you?");
            //the values from a user are always string
            String age = Console.ReadLine();
            Console.WriteLine("you are" + " " + age);
            Console.ReadLine();
        }
    }
}
