using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.接口与多态
{
    /// <summary>
    /// 会议接口
    /// </summary>
    public interface IMeeting
    {
        //void Speech() { }   //接口是不能有任何的实现，即使是一个{}没有任何方法体都不行

        /// <summary>
        /// 演讲
        /// </summary>
        void Speech();

        /// <summary>
        /// 讨论
        /// </summary>
        /// <param name="topic"></param>
        /// <returns></returns>
        string Talk(string topic);

        //其他接口，可以根据需要添加...

    }
}
