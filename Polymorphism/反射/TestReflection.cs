using Polymorphism.对象在工厂中创建;
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
                //item.Name：类的名称
                //item：类的完全限定名（命名空间+类名）
                Console.WriteLine(item.Name+"\t\t"+item);
            }

            //我们从一个程序集中，能够找到所有的类型（类类型、接口类型、泛型类型......)

            Console.WriteLine("======================================================");

            // 官方解释：获取程序集实例中具有指定名称的 System.Type 对象。
            //老师解释：根据一个类的完全限定名字符串，从程序集中得到这个类的具体类型

            Type teacherType = ass1.GetType("Polymorphism.对象在工厂中创建.Teacher");//这个字符串严格区分大小写
            PropertyInfo[]  properities = teacherType.GetProperties();



            //  使用指定类型的默认构造函数来创建该类型的实例。
            Teacher teacher = (Teacher)Activator.CreateInstance(teacherType);

            //合并在一起
            teacher = (Teacher)ass1.CreateInstance("Polymorphism.对象在工厂中创建.Teacher");
            teacher=(Teacher)Assembly.Load("Polymorphism").CreateInstance("Polymorphism.对象在工厂中创建.Teacher");
            //拆开：


            //创建带参数的构造函数创建实例
            object object1 =Activator.CreateInstance(teacherType, new object[] { "常老师"});


        }

    }
}
