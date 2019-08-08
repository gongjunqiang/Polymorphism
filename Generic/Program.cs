using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStack();
            Console.ReadLine();

        }

        //static T3 Add<T1, T2, T3>(T1 a, T2 b)
        //{
        //    return a + b;

        //}

        static void TestStack()
        {


            Demo<int> deom = new Demo<int>(5);
            deom.Push(1);
            deom.Push(2);
            deom.Push(3);
            deom.Push(4);
            deom.Push(5);
            Console.WriteLine(deom.Pop());
            Console.WriteLine(deom.Pop());
            Console.WriteLine(deom.Pop());
            Console.WriteLine(deom.Pop());
            Console.WriteLine(deom.Pop());
        }
    }
}
