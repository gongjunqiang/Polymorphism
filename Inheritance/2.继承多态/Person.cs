using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance._2.继承多态
{
    /// <summary>
    /// 父类：人类
    /// </summary>
    public abstract class Person
    {
        //共同属性
        public string Name { get; set; }
        public int PersonId { get; set; }
        public DateTime Birthday { get; set; }

        public Person()
        {
        }

        public Person(string name,int personId,string number)
        {
            this.Name = name;
            this.PersonId = personId;
            this.PhoneNumber = number;
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




        #region 多态继承
        //只能给子类使用，不能通过子类对象去使用
        protected string PhoneNumber { get; set; }

        //抽象方法
        public abstract void Have();

        //虚方法:父类可以实现该方法，子类可以对该方法重写，但不具有强制性
        public virtual void Sleep()
        {
            Console.WriteLine("【父类】虚方法输出：开始睡觉...");
        }
        #endregion
    }
}
