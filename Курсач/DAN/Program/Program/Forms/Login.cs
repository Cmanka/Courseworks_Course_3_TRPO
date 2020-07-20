using Program.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Login : Form
    {
        MyAppContext context;
        public Login()
        {
            InitializeComponent();
            context = new MyAppContext();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = LoginTB.Text;
            string password = PasswordTB.Text;

            var user = context.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
            LoginButton.Enabled = false;
            if (user != null)
            {
                MessageBox.Show("Success, authorization");
                this.Hide();
                Forms.Menu menu = new Forms.Menu();
                menu.Show();
            }
            else
                MessageBox.Show("Incorrect login or password");
            LoginButton.Enabled = false;

        }
    }
}
