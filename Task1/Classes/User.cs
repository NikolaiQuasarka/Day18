using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    public abstract class User
    {
        protected string loginName;
        protected string password;

        public User(string loginName, string password)
        {
            this.loginName = loginName;
            this.password = password;
        }

        public bool Enter(string login, string password)
        {
            if (loginName == login && this.password == password)
                return true;
            return false;
        }
    }
}
