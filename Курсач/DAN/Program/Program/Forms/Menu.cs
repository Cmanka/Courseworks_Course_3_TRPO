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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MSellersButton_Click(object sender, EventArgs e)
        {
            Sellers sm = new Sellers();
            this.Hide();
            sm.Show();
        }

        private void MShopsButton_Click(object sender, EventArgs e)
        {
            Shops sm = new Shops();
            this.Hide();
            sm.Show();
        }
    }
}
