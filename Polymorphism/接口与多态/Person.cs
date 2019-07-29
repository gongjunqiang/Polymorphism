using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.接口与多态
{
    /// <summary>
    /// 父类
    /// </summary>
    public abstract class Person
    {
        //共同属性
        public string Name { get; set; }
        public string Id { get; set; }
        public DateTime DateOfBirth { get; set; }

        protected string PhoneNumber { get; set; }

        public Person() { }
        public Person(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }

        //共同的行为
        public void CommonDowork()
        {
            Console.WriteLine($"【父类】方法输出：{Name}   在工作中...");
        }

        //抽象方法：也就是父类规范一个行为要求，具体实现由子类完成（但是这个具有强制性）
        public abstract void Have();

        //补充：抽象方法必须放到抽象类中，但是一个抽象类是可以没有任何抽象方法的。

    }
}
