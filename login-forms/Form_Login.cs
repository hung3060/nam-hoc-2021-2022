using login_forms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_forms
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        UserDao user;
        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //dùng đóng chương trình
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //kiểm tra 2 txtbox có nhập hay không
            if(!string.IsNullOrEmpty(txtUserName.Text))
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    user = new UserDao();
                   if( KiemTraDangNhap(txtUserName.Text,txtPassword.Text))
                    {
                        this.Close();
                    }
                   else
                    {
                        lblErro.Text = " Tên hoặc Mật khẩu sai !!!";
                    }

                }
            }
        }

        private bool KiemTraDangNhap(string userName, string passWord)
        {
            if(user.user.UserName.Equals(userName)&& user.user.PassWord.Equals(passWord))
            {
                return true;
            }
            return false;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
