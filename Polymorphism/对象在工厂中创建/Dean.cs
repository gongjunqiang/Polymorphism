using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.对象在工厂中创建
{
    public class Dean : Person, ITeach
    {
        /// <summary>
        /// 来自ITeach的接口实现1：教学研究
        /// </summary>
        public void StudyCourse()
        {
            Console.WriteLine("教务人员正在研究教学内容...");
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

        public override void Have()
        {
            Console.WriteLine("主任正在吃饭...");
        }
    }
}
