using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance._1.普通继承
{
    /// <summary>
    /// 父类：人类
    /// </summary>
    public class Person
    {
        //共同属性
        public string Name { get; set; }
        public int PersonId { get; set; }
        public DateTime Birthday { get; set; }

        public Person()
        {
        }

        public Person(string name,int personId)
        {
            this.Name = name;
            this.PersonId = personId;
        }

        //共同行为
        public void Work()
        {
            Console.WriteLine($"【父类】方法输出：{Name}   在工作中..."); ;
        }
        //父类私有行为
        private void MyProperty()
        {
            Console.WriteLine("父类的私有行为。。。。。。。");
        }

    }
}
