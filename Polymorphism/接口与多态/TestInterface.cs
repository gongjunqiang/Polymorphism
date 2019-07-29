using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.接口与多态
{
    public class TestInterface
    {

        public  static void Test01()
        {
            #region 重写抽象方法测试
            //Console.WriteLine("---------Teacher--------------");
            //Teacher teacher = new Teacher("常老师");
            //teacher.Lecture();
            //teacher.Have();
            //Console.WriteLine();

            //Console.WriteLine("---------President--------------");
            //President president = new President("王校长");
            //president.Have();
            //Console.WriteLine();
            #endregion

            #region IMeeting测试
            //Console.WriteLine("---------Teacher--------------");
            //IMeeting teacher = new Teacher("常老师");
            //teacher.Speech();
            //Console.WriteLine(teacher.Talk(".NET全栈课程基础"));



            //Console.WriteLine("---------President--------------");
            //IMeeting president = new President("王校长");
            //president.Speech();
            //Console.WriteLine(president.Talk("放假时间"));
            #endregion

            #region 接口多态测试

            IMeeting president = new President("王校长");
            Test02(president);
            Console.WriteLine();
            Console.WriteLine("---------------------");
            var meeting = Test03();
            meeting.Speech();
            Console.WriteLine(meeting.Talk("教学内容"));

            #endregion
        }

        /// <summary>
        /// 接口多态实现1：接口作为传递参数类型，实际上传递的是接口的实现类对象
        /// </summary>
        /// <param name="meeting"></param>
        private static void Test02(IMeeting meeting)
        {
            meeting.Speech();
            Console.WriteLine(meeting.Talk("组织考试"));
        }

        /// <summary>
        /// 接口多态实现2：接口作为返回参数类型，实际上返回的是接口的实现类对象
        /// </summary>
        /// <returns></returns>
        private static IMeeting Test03()
        {
            return new Teacher(){Name = "何老师"};
        }


        public static void Test04()
        {
            ITeach teach = new Teacher("张老师");
            Test05(teach);
            Console.WriteLine("===============");

            teach = Test06();
            teach.StudyCourse();
            
            Console.WriteLine(teach.Exam("456"));


            ////以下行为是不能使用的，面向抽象编程，我们只能使用当前的抽象类型所规定的行为
            //teach.Speech();
            //teach.Talk("《全栈和上位机VIP课程平时学习问题》");

            //通过抽象类型，让抽象的行为严格隔离

        }



        private static void Test05(ITeach teach)
        {
            teach.StudyCourse();
            Console.WriteLine(teach.Exam("123"));
            ;
        }

        private static ITeach Test06()
        {

            //return new Dean();
            return new Teacher();
        }

    }


}

