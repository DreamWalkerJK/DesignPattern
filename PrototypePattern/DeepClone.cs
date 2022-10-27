using System;

namespace PrototypePattern
{
    /// <summary>
    /// 深拷贝
    /// 拷贝的新对象的引用指向新对象，原对象的引用还是原对象
    /// </summary>
    public class DeepClone : ICloneable
    {
        private int age;
        private string address;
        private UserDeep userDeep;

        public DeepClone(int age, string address)
        {
            this.age = age;
            this.address = address;
            userDeep = new UserDeep();
        }

        public void SetUserDeep(string name, string gender)
        {
            userDeep.name = name;
            userDeep.gender = gender;
        }

        public DeepClone(UserDeep userDeep)
        {
            this.userDeep = (UserDeep)userDeep.Clone();
        }

        public void Show()
        {
            Console.WriteLine($"{userDeep.name}: {userDeep.gender},{this.age},{this.address}");
        }

        public object Clone()
        {
            DeepClone deepClone = new DeepClone(userDeep);
            deepClone.age = this.age;
            deepClone.address = this.address;
            return deepClone;
        }
    }
}
