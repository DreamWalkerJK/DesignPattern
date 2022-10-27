using System;

namespace SingletonPattern
{
    /// <summary>
    /// 单例模式：Single Pattern
    /// 指确保一个类在任何情况下都绝对只有一个实例，并提供一个全局访问点
    /// 优点：可保证内存里只有一个实例，减少开销、避免对资源的多重占用、设置全局访问点，优化和共享资源的访问
    /// 缺点：一般没有接口，拓展困难、并发测试中，不利于代码调试、容易违背单一职责原则
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StandarnSingleton standarnSingleton = StandarnSingleton.GetSingleton();
            standarnSingleton.ShowMessage();

            Console.WriteLine();

            LazySingleton lazySingleton = LazySingleton.GetSingleton();
            lazySingleton.ShowMessage();

            LazySafeSingleton lazySafeSingleton = LazySafeSingleton.GetSingleton();
            lazySafeSingleton.ShowMessage();

            Console.WriteLine();
            LazyDoubleSafeSingleton lazyDoubleSafeSingleton = LazyDoubleSafeSingleton.GetSingleton();
            lazyDoubleSafeSingleton.ShowMessage();

            Console.ReadKey();
        }
    }
}
