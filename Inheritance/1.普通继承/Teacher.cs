using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance._1.普通继承
{
    public class Teacher : Person
    {

        public string Major { get; set; }
        public string CourseCount { get; set; }


        //特有方法
        public void Lecture()
        {
            Console.WriteLine($"【Teacher子类】方法输出：{Name}  {Major} 正在授课...");
        }

    }
}
