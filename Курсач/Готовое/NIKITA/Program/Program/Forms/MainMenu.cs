using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.Forms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MastersButton_Click(object sender, EventArgs e)
        {
            Masters m = new Masters();
            this.Hide();
            m.Show();
        }

        private void ServicesButton_Click(object sender, EventArgs e)
        {
            Services s = new Services();
            this.Hide();
            s.Show();
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            Clients c = new Clients();
            this.Hide();
            c.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
