using System;

namespace PrototypePattern
{
    /// <summary>
    /// 原型模式：Prototype Pattern
    /// 指原型实例指定创建对象的种类，并且通过复制这些原型创建新的对象
    /// 优点：性能提高、避免构造函数的约束
    /// 缺点：每一个类都需要实现ICloneable接口
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("浅拷贝：");
            ShallowCopy shallowCopy = new ShallowCopy(11, "qingqingcaoyuan");
            shallowCopy.SetUser("xiyangyang", "male");

            ShallowCopy shallowCopy1 = (ShallowCopy)shallowCopy.Clone();
            shallowCopy1.SetUser("meiyangyang", "female");

            shallowCopy.Show();
            shallowCopy1.Show();

            Console.WriteLine("深拷贝：");
            DeepClone deepClone = new DeepClone(31, "langbao");
            deepClone.SetUserDeep("huitailang", "male");

            DeepClone deepClone1 = (DeepClone)deepClone.Clone();
            deepClone1.SetUserDeep("xiaohuihui", "female");
            deepClone.Show();
            deepClone1.Show();

            Console.ReadKey();
        }
    }
}
