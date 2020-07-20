using Program.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.Forms
{
    public partial class Masters : Form
    {
        MyContext context;
        public Masters()
        {
            InitializeComponent();
            context = new MyContext();
            context.Masters.Load();
            dataGridView1.DataSource = context.Masters.Local.ToBindingList();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            AddEditMaster aem = new AddEditMaster();

            DialogResult result = aem.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;
            if (aem.NameTB.Text == "")
            {
                MessageBox.Show("Поле имя было незаполненно");
                return;
            }
            Master master = new Master()
            {
                Name = aem.NameTB.Text,
                Number = (int)aem.NumberTB.Value,
                IsMaterial = aem.MaterialCB.Checked
            };

            context.Masters.Add(master);

            await context.SaveChangesAsync();
            MessageBox.Show("Мастер был добавлен");
            dataGridView1.Refresh();
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Master master = await context.Masters.FindAsync(id);

                AddEditMaster aem = new AddEditMaster();

                aem.NameTB.Text = master.Name;
                aem.NumberTB.Value = (decimal)master.Number;
                aem.MaterialCB.Checked = master.IsMaterial;

                DialogResult result = aem.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;
                if (aem.NameTB.Text == "")
                {
                    MessageBox.Show("Поле имя было незаполненно");
                    return;
                }
                master.Name = aem.NameTB.Text;
                master.Number = (int)aem.NumberTB.Value;
                master.IsMaterial = aem.MaterialCB.Checked;

                await context.SaveChangesAsync();
                MessageBox.Show("Мастер был изменён");
                dataGridView1.Refresh();

            }
        }

        private async void RemoveButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Master master = await context.Masters.FindAsync(id);
                context.Masters.Remove(master);
                await context.SaveChangesAsync();

                MessageBox.Show("Мастер был удалён");
                dataGridView1.Refresh();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            this.Hide();
            mm.Show();
        }
    }
}
