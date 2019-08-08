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

    #region 泛型中default关键字的使用
    public class Generic<T1,T2>
    {

        private T1 data1;
        private T2 data2;


        public Generic()
        {
            //data1 =new T1();//因为T1的类型不能确定是否未引用类型，所以不能直接使用关键字New
            //data1 = null;//值类型有时候不能未null
            data1 = default(T1);
            data2 = default(T2);
        }


    }


    #endregion

}
