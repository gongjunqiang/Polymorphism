using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance._1.普通继承
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
        public Student(string name, int id, int studentId, string className)
            : base(name, id)
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

    }
}
