using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.对象在工厂中创建
{
    /// <summary>
    /// 教学相关的接口
    /// </summary>
    public interface ITeach
    {   /// <summary>
        /// 教学研究
        /// </summary>
        void StudyCourse();

        /// <summary>
        /// 考试
        /// </summary>
        /// <param name="term"></param>
        /// <returns></returns>
        bool Exam(string term);
    }
}
