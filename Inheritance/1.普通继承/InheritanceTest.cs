using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance._1.普通继承
{
    public class InheritanceTest
    {
        public static void Test01()
        {
            Console.WriteLine("-----------Teacher----------");
            Teacher teacher = new Teacher();
            //父类属性
            teacher.Name = "张老师";
            teacher.PersonId = 10001;
            teacher.Birthday = DateTime.Now;

            //Teacher特有属性
            teacher.CourseCount = "3";
            teacher.Major = ".NET全栈";

            //父类公有行为
            teacher.Work();
            //Teacher行为
            teacher.Lecture();
            Console.WriteLine("-----------Student----------");
            Student student = new Student();
            //父类属性
            student.Name = "龚同学";
            student.PersonId = 100000000;
            student.Birthday = DateTime.MaxValue;

            //Student特有属性
            student.ClassName = "计算机一班";
            student.StudentId = 999;

            //父类公有行为
            student.Work();
            //Student行为
            student.DoHomeWork();
            student.Study();

            Console.WriteLine("-----------Student构造方法----------");

            Student students = new Student("何同学",1,888, "软件一班");
            //父类公有行为
            students.Work();
            //Student行为
            students.DoHomeWork();
            students.Study();

        }




    }
}
