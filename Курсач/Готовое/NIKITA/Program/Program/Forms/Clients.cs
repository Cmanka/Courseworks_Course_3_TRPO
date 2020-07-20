using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program.Models;
using System.Data.Entity;

namespace Program.Forms
{
    public partial class Clients : Form
    {
        MyContext context;
        List<Service> services;
        public Clients()
        {
            InitializeComponent();
            context = new MyContext();
            services = context.Services.ToList();
            context.Clients.Load();
            dataGridView1.DataSource = context.Clients.Local.ToBindingList();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            AddEditClient aec = new AddEditClient();

            aec.ServiceCB.DataSource = services;
            aec.ServiceCB.ValueMember = "Id";
            aec.ServiceCB.DisplayMember = "Name";


            DialogResult result = aec.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Client client = new Client()
            {
                Firstname = aec.FirstnameTB.Text,
                Surname = aec.SecondnameTB.Text,
                Lastname = aec.LastnameTB.Text,
                Number = (int)aec.NumberTB.Value,
                OrderTime = aec.dataTB.Value,
                Service = (Service)aec.ServiceCB.SelectedItem
            };

            context.Clients.Add(client);
            await context.SaveChangesAsync();
            MessageBox.Show("Клиент был добавлен");
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

                Client client = await context.Clients.FindAsync(id);

                AddEditClient aec = new AddEditClient();

                aec.FirstnameTB.Text = client.Firstname;
                aec.SecondnameTB.Text = client.Surname;
                aec.LastnameTB.Text = client.Lastname;
                aec.NumberTB.Value = (decimal)client.Number;
                aec.dataTB.Value = client.OrderTime;
                aec.ServiceCB.SelectedItem = client.Service;

                aec.ServiceCB.DataSource = services;
                aec.ServiceCB.ValueMember = "Id";
                aec.ServiceCB.DisplayMember = "Name";

                DialogResult result = aec.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                client.Firstname = aec.FirstnameTB.Text;
                client.Surname = aec.SecondnameTB.Text;
                client.Lastname = aec.LastnameTB.Text;
                client.Number = (int)aec.NumberTB.Value;
                client.OrderTime = aec.dataTB.Value;;
                client.Service = (Service)aec.ServiceCB.SelectedItem;

                await context.SaveChangesAsync();
                MessageBox.Show("Клиент был изменен");
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

                Client client = await context.Clients.FindAsync(id);
                context.Clients.Remove(client);
                await context.SaveChangesAsync();

                MessageBox.Show("Клиент был удален");
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
