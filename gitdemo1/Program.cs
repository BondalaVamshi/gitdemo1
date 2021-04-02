using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitdemo1
{
    class class1
    {

        public void hello()
        {
            Console.WriteLine("this is the the method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            class1 c1 = new class1();
            c1.hello();
            Console.WriteLine("hello wolrd");
            Console.ReadLine();
        }
      
    }
    
}
