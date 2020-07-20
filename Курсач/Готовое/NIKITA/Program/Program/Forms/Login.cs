using Program.Models;
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
    public partial class Form1 : Form
    {
        MyContext context;
        public Form1()
        {
            InitializeComponent();
            context = new MyContext();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = loginTB.Text;
            string password = passTB.Text;

            var user = context.Users.FirstOrDefault(u => u.Login == login && u.Password == password);

            if (user != null)
            {
                MessageBox.Show("Успешная авторизация");
                Forms.MainMenu mm = new Forms.MainMenu();
                this.Hide();
                mm.Show();
            }
            else
                MessageBox.Show("Логин или пароль были введены неверно");
        }
    }
}
