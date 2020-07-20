using Program.Data;
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
    public partial class Login : System.Windows.Forms.Form
    {
        MyContext context;
        public Login()
        {
            InitializeComponent();
            context = new MyContext();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string pass = PasswordTextBox.Text;

            var user = context.Users.FirstOrDefault(u => u.Login == login && u.Password == pass);
           

            if (user != null)
            {
                MessageBox.Show("Success, authorization");
                this.Hide();
                Formes.Menu menu = new Formes.Menu();
                menu.Show();
            }  
            else
                MessageBox.Show("Incorrect login or password");

        }
    }
}
