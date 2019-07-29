using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.接口与多态
{
    /// <summary>
    /// 校长类
    /// </summary>
    public class President:Person, IMeeting
    {
        public President() { }
        public President(string name) { this.Name = name; }

        public override void Have()
        {
            Console.WriteLine($"{Name}正在就餐...");
        }

        #region IMeeting
        public void Speech()
        {
            Console.WriteLine($"{Name}正在演讲...");
        }

        public string Talk(string topic)
        {
            return $"{Name}  针对 {topic} 正在讨论...";
        }
        #endregion


    }
}
