using System;

namespace SingletonPattern
{
    /// <summary>
    /// 懒汉式单例：单例对象在被使用时才会初始化
    /// 优点：解决饿汉式单例可能带来的内存浪费问题
    /// 缺点：多线程情况下，出现线程安全问题
    /// </summary>
    public sealed class LazySingleton
    {
        private LazySingleton(){}

        private static LazySingleton singleton = null;

        public static LazySingleton GetSingleton()
        {
            if(singleton == null)
            {
                singleton = new LazySingleton();
            }

            return singleton;
        }

        public void ShowMessage()
        {
            Console.WriteLine("懒汉式单例");
        }

    }
}
