using Program.Model;
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
    public partial class Sellers : Form
    {
        MyAppContext context;
        List<Shop> shops;
        public Sellers()
        {
            InitializeComponent();
            context = new MyAppContext();
            shops = context.Shops.ToList();
            context.Selleres.Load();
            dataGridView1.DataSource = context.Selleres.Local.ToBindingList();
            dataGridView1.Refresh();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            AddEditSeller addSeller = new AddEditSeller();

            addSeller.ShopCB.DataSource = shops;
            addSeller.ShopCB.ValueMember = "Id";
            addSeller.ShopCB.DisplayMember = "Name";

            DialogResult result = addSeller.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Seller seller = new Seller()
            {
                Shop = (Shop)addSeller.ShopCB.SelectedItem,
                Firstname = addSeller.FirstNameTB.Text,
                Surname = addSeller.SurnameTB.Text,
                Address = addSeller.AddressTB.Text,
                DataBirth = addSeller.dateOfBirthBox.Value,
                NumberPassport = (int)addSeller.NumberPassp.Value,
                NameGetPassport = addSeller.NameGetPasppBox.Text,
                DataGetPassport = addSeller.DateGetPassportBox.Value,
                Department = addSeller.DepartmentTB.Text
            };

            context.Selleres.Add(seller);
            await context.SaveChangesAsync();
            MessageBox.Show("Seller was added");
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

                Seller seller = await context.Selleres.FindAsync(id);

                AddEditSeller addSeller = new AddEditSeller();

                addSeller.ShopCB.DataSource = shops;
                addSeller.ShopCB.ValueMember = "Id";
                addSeller.ShopCB.DisplayMember = "Name";

                addSeller.ShopCB.SelectedItem = seller.Shop;
                addSeller.FirstNameTB.Text = seller.Firstname;
                addSeller.SurnameTB.Text = seller.Surname;
                addSeller.AddressTB.Text = seller.Address;
                addSeller.dateOfBirthBox.Value = seller.DataBirth;
                addSeller.NumberPassp.Value = seller.NumberPassport;
                addSeller.NameGetPasppBox.Text = seller.NameGetPassport;
                addSeller.DateGetPassportBox.Value = seller.DataGetPassport;
                addSeller.DepartmentTB.Text = seller.Department;

                DialogResult result = addSeller.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                seller.Shop = (Shop)addSeller.ShopCB.SelectedItem;
                seller.Firstname = addSeller.FirstNameTB.Text;
                seller.Surname = addSeller.SurnameTB.Text;
                seller.Address = addSeller.AddressTB.Text;
                seller.DataBirth = addSeller.dateOfBirthBox.Value;
                seller.NumberPassport = (int)addSeller.NumberPassp.Value;
                seller.NameGetPassport = addSeller.NameGetPasppBox.Text;
                seller.DataGetPassport = addSeller.DateGetPassportBox.Value;
                seller.Department = addSeller.DepartmentTB.Text;

                await context.SaveChangesAsync();
                MessageBox.Show("Seller was updated");
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

                Seller seller = await context.Selleres.FindAsync(id);
                context.Selleres.Remove(seller);
                await context.SaveChangesAsync();

                MessageBox.Show("Seller was deleted");
                dataGridView1.Refresh();
            }
        }

        private void ToMenuButton_Click(object sender, EventArgs e)
        {
            Forms.Menu menu = new Forms.Menu();
            this.Hide();
            menu.Show();
        }
    }
}
