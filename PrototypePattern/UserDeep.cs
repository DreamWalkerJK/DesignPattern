using System;

namespace PrototypePattern
{
    public class UserDeep : ICloneable
    {
        public string name;
        public string gender;

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
