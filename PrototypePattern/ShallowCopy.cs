using System;

namespace PrototypePattern
{
    /// <summary>
    /// 浅拷贝
    /// 拷贝的新对象的引用和原对象的引用，都指向原对象的引用
    /// </summary>
    public class ShallowCopy : ICloneable
    {
        private int age;
        private string address;
        private User user;

        public ShallowCopy(int age, string address)
        {
            this.age = age;
            this.address = address;
            user = new User();
        }

        public void SetUser(string name, string gender)
        {
            user.name = name;
            user.gender = gender;
        }

        public void Show()
        {
            Console.WriteLine($"{user.name} : {user.gender},{this.age},{this.address}");
        }

        public object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }
}
