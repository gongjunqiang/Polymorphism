using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.对象在工厂中创建
{
    /// <summary>
    /// 教师类
    /// </summary>
    public class Teacher:Person,ITeach
    {
        //特有的属性
        public string Post { get; set; }
        public int Salary { get; set; }

        public Teacher()
        {
            this.Name = "张老师";
        }
        public Teacher(string name)
        { this.Name = name; }

        /// <summary>
        /// 特有的方法
        /// </summary>
        public void Lecture()
        {
            Console.WriteLine($"【Teacher子类】方法输出：{Name} 正在授课...");
        }

        /// <summary>
        /// 重写父类的方法
        /// </summary>
        public override void Have()
        {
            Console.WriteLine($"{Name}正在吃饭...");
        }

        #region ITeach

        /// <summary>
        /// 来自ITeach的接口实现1：教学研究
        /// </summary>
        public void StudyCourse()
        {
            Console.WriteLine("老师正在研究教学内容...");
        }
        /// <summary>
        /// 来自ITeach的接口实现2：组织考试
        /// </summary>
        /// <param name="term"></param>
        /// <returns></returns>
        public bool Exam(string term)
        {
            //其他业务调用...true表示考试完毕...

            return true;
        }

        #endregion
    }
}
