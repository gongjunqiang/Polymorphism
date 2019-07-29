using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.对象在工厂中创建
{
    public class OtherTeacher:ITeach
    {
        public bool Exam(string term)
        {
            //前面省略...


            return true;
        }

        public void StudyCourse()
        {
            Console.WriteLine("我们是外校老师，来这里参与教学研究......");
        }
    }
}
