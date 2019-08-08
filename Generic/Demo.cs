using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Demo<T>
    {
        public T[] stack;
        public int size;

        public int stackPoint;

        public Demo(int size)
        {
            this.size = size;
            this.stack = new T[size];
            this.stackPoint = -1;
        }


        /// <summary>
        /// 元素入栈
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            if (stackPoint >= size)
            {
                Console.WriteLine("占空间已满");
            }
            else
            {
                stackPoint++;
                this.stack[stackPoint] = item;
            }
        }

        public T Pop()
        {
            T data = this.stack[stackPoint];
            stackPoint--;
            return data;
        }

    }

    #region 泛型中default关键字的使用：主要用于给泛型变量赋值
    public class Generic<T1,T2>
    {

        private T1 data1;
        private T2 data2;


        public Generic()
        {
            //data1 =new T1();//因为T1的类型不能确定是否未引用类型，所以不能直接使用关键字New
            //data1 = null;//值类型有时候不能未null
            data1 = default(T1);//如果T1是引用类型，则赋值位bull，如果是值类型，就给默认值
            data2 = default(T2);
        }


    }

    #endregion

    #region 泛型约束

    public class GenericConstraint<T1, T2, T3>
        where T1:struct//约束T1必须是值类型
        where T2:class//约束T2必须是引用类型
        where T3:new()//约束T3这个类型必须有一个无参数构造方法，这个约束必须放在约束的最后面


        //其他类型：基类型、接口类型
    {
        public List<T2> ProductList { get; set; }

        public T3 Publish { get; set; }

        public GenericConstraint()
        {
            //this.ProductList = new List<T2>();
            //Publish = new T3();//因为泛型中没有规定这个类型有无无参数构造方法，所以不能直接使用，加上约束后可以使用
        }

        public T2 ByCourse(T1 position)
        {
            //var index = position;

            dynamic index = position;//动态类型：再运行时解析对象的类型，再编译阶段不解析
            return this.ProductList[index];
        }
    }


    public class Course
    {
        public string CourseName { get; set; }
        public int Id { get; set; }

    }

    public class Teacher
    {

        public string TeacherName { get; set; }
        public int CourseCount { get; set; }

        //public Teacher()
        //{ }

    }
    #endregion
}





