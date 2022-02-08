using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryMyBikes;

namespace MyBikes
{
    public partial class login : Form
    {
        LoginUser lgn = new LoginUser();
        public login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            
            if(lgn.ValidateLogin(userName,password))
            {
                Form1 form = new Form1();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid UserName and Password", "Error");
                textBoxUserName.Clear();
                textBoxUserName.Focus();
                textBoxPassword.Clear();
            }
        }

        private void labelHint_Click(object sender, EventArgs e)
        {
            string hint = "Try the following UserName and Password" +
                "\nUserName : " + lgn.Username + "\nPassword : " + lgn.Password;
            MessageBox.Show(hint, "Hint");
        }
    }
}
