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

            TestGenericConstraint();
            Console.WriteLine("--------------委托技术-------------");
            //【3】定义委托变量
            Lecturedelegate1 lecture1 =null;//引用类型
            //【4】将委托变量与具体方法关联
            lecture1 = ChangeLecture1;

            lecture1 += ZhangeLecture1;
            lecture1 += WangeLecture1;


            //【5】通过委托变量使用方法
            //lecture1();
            lecture1.Invoke();//委托特有的Invoke()
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


        /// <summary>
        /// 测试泛型约束
        /// </summary>
        static void TestGenericConstraint()
        {
            GenericConstraint<int, Course, Teacher> generic = new GenericConstraint<int, Course, Teacher>();

            //给对象属性赋值
            generic.ProductList = new List<Course>
            {
                new Course{ CourseName = "英语",Id=1000},
                 new Course{ CourseName = "数学",Id=1000},
                  new Course{ CourseName = "物理",Id=1000}
            };
            generic.Publish = new Teacher() { TeacherName = "常老师", CourseCount = 3 };

            var course = generic.ByCourse(0);
            Console.WriteLine($"课程老师：{generic.Publish.TeacherName},课程Id{course.Id},课程名称{course.CourseName}");
        }

        //【2】根据委托编写方法
        static void ChangeLecture1()
        {
            Console.WriteLine("委托技术");
        }

        static void ZhangeLecture1()
        {
            Console.WriteLine("Zhange委托技术");
        }

        static void WangeLecture1()
        {
            Console.WriteLine("Zhange委托技术");
        }


    }

    //声明委托(声明方法的原型：方法的返回值与参数个数)
    public delegate void Lecturedelegate1();
}
