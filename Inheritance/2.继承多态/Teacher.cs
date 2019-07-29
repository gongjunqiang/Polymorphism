using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance._2.继承多态
{
    public class Teacher : Person
    {

        public string Major { get; set; }
        public string CourseCount { get; set; }


        public Teacher(string name, string phoneNumber)
        {
            base.Name = name;
            base.PhoneNumber = phoneNumber;//这个PhoneNumber是受保护级别的
        }


        //特有方法
        public void Lecture()
        {
            Console.WriteLine($"【Teacher子类】方法输出：{Name}  {Major} 正在授课...");
        }

        /// <summary>
        /// 父类抽象方法重写：具有强制性
        /// </summary>
        public override void Have()
        {
            Console.WriteLine("来自子类Teacher重写的方法：今天晚上为了给大家准时上课，我讲完课再出去吃饭！");
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
    }
}
