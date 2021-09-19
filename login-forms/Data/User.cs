using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_forms.Data
{
    public class User
    {
        private int iD;
        private String userName;
        private string passWord;
        private bool remember;

        public int ID { get { return iD; } set { iD = value; } }

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public bool Remember { get => remember; set => remember = value; }
    }
}
