using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_forms.Data
{
    public class UserDao
    {
        public User user;
        public UserDao()
        {
            user = new User() { ID = 1, UserName = "nguyenminhhung", PassWord = "123456", Remember = true };
        }
    }
}
