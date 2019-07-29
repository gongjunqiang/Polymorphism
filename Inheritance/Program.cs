using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance._1.普通继承;
using Inheritance._2.继承多态;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 普通继承测试
            //InheritanceTest.Test01();
            #endregion

            #region 继承多态测试

            _2.继承多态.InheritanceTest.Test02();

            #endregion


            Console.ReadLine();


        }
    }
}
