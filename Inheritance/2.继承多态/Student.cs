using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance._2.继承多态
{
    public class Student:Person
    {
        //特有属性
        public int StudentId { get; set; }
        public string ClassName { get; set; }


        public Student(){ }

        /// <summary>
        /// 调用父类构造方法的构造方法
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="studentId"></param>
        /// <param name="className"></param>
        public Student(string name, int id, int studentId, string className,string number)
            : base(name, id, number)
        {
            this.StudentId = studentId;
            this.ClassName = className;
        }

        //特有方法
        public void DoHomeWork()
        {
            Console.WriteLine($"【Student子类】方法输出：{Name}  {ClassName}  正在做作业...");
        }
        public void Study()
        {
            Console.WriteLine($"【Student子类】方法输出：{Name}  {ClassName}  正在学习...");
        }


        /// <summary>
        /// 父类虚方法重写：不具有强制性
        /// </summary>
        public override void Sleep()
        {
            //添加自己的实现
            Console.WriteLine("来自子类Student重写的方法：听完课后，马上巩固一下！");
            //base.Sleep(); //调用父类的虚方法
        }

        /// <summary>
        /// 父类抽象方法重写：具有强制性
        /// </summary>
        public override void Have()
        {
            Console.WriteLine("来自子类Student重写的方法：今天晚上听完常老师的课程，我还要吃夜宵！");
        }
    }
}
