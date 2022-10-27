using System;

namespace SingletonPattern
{
    /// <summary>
    /// 懒汉式单例（线程安全）
    /// 优点：避免内存浪费
    /// 缺点：性能不佳
    /// </summary>
    public sealed class LazySafeSingleton
    {
        private static LazySafeSingleton safeSingleton = null;
        private static readonly object obj = new object();

        private LazySafeSingleton() { }

        public static LazySafeSingleton GetSingleton()
        {
            lock (obj)
            {
                if(safeSingleton == null)
                {
                    safeSingleton = new LazySafeSingleton();
                }

                return safeSingleton;
            }
        }

        public void ShowMessage()
        {
            Console.WriteLine("懒汉式单例（线程安全）");
        }
    }
}
