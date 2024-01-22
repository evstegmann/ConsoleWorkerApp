using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class User
    {
        public int Code { get; set; }

        public User(int code)
        {
            Code = code;
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is User))
            {
                throw new ArgumentException("Object is not a User");
            }

            User other = obj as User;
            return Code.Equals(other.Code);
        }
    }
}
