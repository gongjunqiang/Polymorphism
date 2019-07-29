using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Reflection;
using System.Data;
using System.Data.SqlClient;

namespace Polymorphism.对象在工厂中创建
{
    /// <summary>
    /// 对象工厂（简单工厂、单一对象创建工厂）
    /// </summary>
    public class ObjectFactory
    {
        private static string personClass = ConfigurationManager.AppSettings["PersonClass"];
        private static string assName = ConfigurationManager.AppSettings["AssName"];
        /// <summary>
        /// 工厂方法：返回具体接口的实现类对象
        /// </summary>
        /// <returns></returns>
        public static ITeach CreateObject()
        {
            //思考，我们应该创建哪个接口实现类对象呢？Teacher、Dean
            //需求是变化的，我们应该把这种变化，变得可配置（就是不需要代码修改，只需要修改配置文件）



            #region 简单工厂：对象创建
            //if (personClass == "Teacher")
            //{
            //    return new Teacher("常老师");
            //}
            //else if (personClass == "Dean")
            //{
            //    return new Dean();
            //}
            //else
            //{
            //    return new OtherTeacher();
            //}
            #endregion

            //Assembly ass1 = Assembly.Load("Polymorphism");
            return (ITeach)Assembly.Load(assName).CreateInstance(personClass);
        } 
    }
}
