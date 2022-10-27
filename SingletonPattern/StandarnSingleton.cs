using System;

namespace SingletonPattern
{
    /// <summary>
    /// 饿汉式单例（标准）：在类加载立即初始化并创建单例对象
    /// 优点：绝对线程安全，在线程还没出现前就实例化，不可能出现访问安全问题
    /// 缺点：类加载时就初始化，可能浪费内存
    /// </summary>
    public sealed class StandarnSingleton
    {
        private static StandarnSingleton singleton = new StandarnSingleton();

        private StandarnSingleton(){}

        public static StandarnSingleton GetSingleton()
        {
            return singleton;
        }

        public void ShowMessage()
        {
            Console.WriteLine("饿汉式单例（标准）");
        }


    }
}
