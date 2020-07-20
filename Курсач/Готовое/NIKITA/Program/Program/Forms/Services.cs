using Program.Models;
using System.Data.Entity;
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
    public partial class Services : Form
    {
        MyContext context;
        List<Master> masters;
        public Services()
        {
            InitializeComponent();
            context = new MyContext();
            masters = context.Masters.Where(m=>m.IsMaterial).ToList();
            context.Services.Load();
            dataGridView1.DataSource = context.Services.Local.ToBindingList();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            AddEditService aes = new AddEditService();

            aes.MasterCB.DataSource = masters;
            aes.MasterCB.ValueMember = "Id";
            aes.MasterCB.DisplayMember = "Name";


            DialogResult result = aes.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Service service = new Service()
            {
                Master = (Master)aes.MasterCB.SelectedItem,
                Name = aes.NameTB.Text,
                Price = (int)aes.PriceTB.Value
            };

            context.Services.Add(service);
            await context.SaveChangesAsync();
            MessageBox.Show("Услуга была добавлена");
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

                Service service = await context.Services.FindAsync(id);

                AddEditService aes = new AddEditService();

                aes.NameTB.Text = service.Name;
                aes.PriceTB.Value = (decimal)service.Price;
                aes.MasterCB.SelectedItem = service.Master;

                aes.MasterCB.DataSource = masters;
                aes.MasterCB.ValueMember = "Id";
                aes.MasterCB.DisplayMember = "Name";

                DialogResult result = aes.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                service.Master = (Master)aes.MasterCB.SelectedItem;
                service.Name = aes.NameTB.Text;
                service.Price = (int)aes.PriceTB.Value;

                await context.SaveChangesAsync();
                MessageBox.Show("Услуга была изменена");
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

                Service service = await context.Services.FindAsync(id);
                context.Services.Remove(service);
                await context.SaveChangesAsync();

                MessageBox.Show("Услуга была удалена");
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
