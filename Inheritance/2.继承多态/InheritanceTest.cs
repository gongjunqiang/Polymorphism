using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance._2.继承多态
{
    public class InheritanceTest
    {
        #region 测试Protected和重写的抽象方法、虚方法
        public static void Test02()
        {
            //Console.WriteLine("-----------Teacher----------");
            //Teacher teacher = new Teacher("常老师", "18520000000");
            ////Teacher特有属性
            //teacher.CourseCount = "3";
            //teacher.Major = ".NET全栈";
            ////虚方法
            //teacher.Sleep();
            ////抽象方法
            //teacher.Have();
            //Console.WriteLine("-----------Student----------");
            //Student student = new Student("何同学", 1, 888, "软件一班","18408243998");
            
            ////测试虚方法重写
            //student.Sleep();
            ////抽象方法
            //student.Have();



            #region 虚方法实现多态测试
            //父类作为参数类型，实际上传递的是其子类对象;student
            Console.WriteLine("-----------传递Student对象----------");
            Student student = new Student("何同学", 1, 888, "软件一班", "18408243998");
            Test03(student);

            //父类作为返回参数类型，实际上返回的是其子类对象 Student
            Console.WriteLine("-----------返回Student对象----------");
            var person = Test04();
            person.Sleep();
            person.Have();
            //父类作为返回参数类型，实际上返回的是其子类对象 Teacher
            Console.WriteLine("-----------返回teacher对象----------");
            person = Test05();
            person.Sleep();
            person.Have();
            #endregion


        }
        #endregion

        #region 虚方法实现多态：继承多态的两种实现形式
        /// <summary>
        /// 继承多态实现1：父类作为参数类型，实际上传递的是其子类对象
        /// </summary>
        /// <param name="person"></param>
        public static void Test03(Person person)
        {
            person.Have();
            person.Sleep();
        }

        /// <summary>
        /// 继承多态实现2：父类作为返回参数类型，实际上返回的是其子类对象
        /// </summary>
        /// <returns></returns>
        private static Person Test04()
        {
            return new Student();
        }

        private static Person Test05()
        {
            return new Teacher("龚老师","18408230331");
        }
        #endregion

    }
}
