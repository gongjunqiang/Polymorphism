using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphism.反射;
using Polymorphism.对象在工厂中创建;
//using ITeach = Polymorphism.接口与多态.ITeach;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestInterface.Test01();

            //TestInterface.Test04();

            //在工厂在返回对象
            ITeach teach = ObjectFactory.CreateObject();
            teach.StudyCourse();
            Console.WriteLine(teach.Exam("123456789"));


            //反射测试：
            TestReflection.Test();

            Console.ReadLine();
        }
    }
}
