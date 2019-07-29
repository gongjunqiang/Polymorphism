using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.接口与多态
{
    public class Dean : Person, IMeeting, ITeach
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

        /// <summary>
        /// 接口的实现方法1：演讲
        /// </summary>
        public void Speech()
        {
            Console.WriteLine($"{Name}  正在演讲...");
        }

 

        /// <summary>
        /// 接口的实现方法2：讨论
        /// </summary>
        /// <param name="topic"></param>
        /// <returns></returns>
        public string Talk(string topic)
        {
            return $"{Name}  针对 {topic} 正在讨论...";
        }
    }
}
