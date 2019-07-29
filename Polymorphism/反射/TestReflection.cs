using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Polymorphism.反射
{
    /// <summary>
    /// 反射的应用
    /// </summary>
    public class TestReflection
    {
        public static void Test()
        {
            Assembly ass1 = Assembly.Load("Polymorphism");
            Assembly ass2 = Assembly.LoadFile(Directory.GetCurrentDirectory()+ "\\Polymorphism.exe");
            Assembly ass3 = Assembly.LoadFrom("Polymorphism.exe");

            Type[] types = ass1.GetTypes();
            foreach (var item in types)
            {
                Console.WriteLine(item.Name+"\t\t"+item);
            }

        }

    }
}
