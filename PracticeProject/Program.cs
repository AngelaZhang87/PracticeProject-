using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
     public class Program
    {
        
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number to see the name");
            int z = Convert. ToInt32(Console.ReadLine());

            PracticeIfElse Obj = new PracticeIfElse();
            Obj.printName(z);
        }
     
    }
}
