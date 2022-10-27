using System;

namespace SingletonPattern
{
    /// <summary>
    /// 懒汉式单例（双重校验锁）
    /// 优点：在多线程情况下，线程安全且保持高性能
    /// </summary>
    public sealed class LazyDoubleSafeSingleton
    {
        private static LazyDoubleSafeSingleton safeSingleton = null;
        private static readonly object obj = new object();

        private LazyDoubleSafeSingleton() { }

        public static LazyDoubleSafeSingleton GetSingleton()
        {
            // 第一重验证
            if(safeSingleton == null)
            {
                Console.WriteLine("单例实例化验证一");

                // 锁定对象，防止线程多次new
                lock (obj)
                {
                    Console.WriteLine("单例实例化验证二");

                    // 第二重验证
                    if(safeSingleton == null)
                    {
                        safeSingleton = new LazyDoubleSafeSingleton();
                    }
                }
            }
            return safeSingleton;
        }

        public void ShowMessage()
        {
            Console.WriteLine("懒汉式单例（双重校验锁）");
        }
    }
}
