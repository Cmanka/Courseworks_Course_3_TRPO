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
    public partial class Shops : Form
    {
        MyAppContext context;
        List<Product> productes;
        List<Income> incomes;

        public Shops()
        {
            InitializeComponent();
            context = new MyAppContext();
            productes = context.Product.ToList();
            incomes = context.Incomes.ToList();
            context.Shops.Load();
            dataGridView1.DataSource = context.Shops.Local.ToBindingList();
            dataGridView1.Refresh();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Forms.Menu menu = new Forms.Menu();
            this.Hide();
            menu.Show();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            AddEditShop addShop = new AddEditShop();

            addShop.ProductCB.DataSource = productes;
            addShop.ProductCB.ValueMember = "Id";
            addShop.ProductCB.DisplayMember = "Name";

            addShop.IncomeCB.DataSource = incomes;
            addShop.IncomeCB.ValueMember = "Id";
            addShop.IncomeCB.DisplayMember = "Date";

            DialogResult result = addShop.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Shop shop = new Shop()
            {
                Product = (Product)addShop.ProductCB.SelectedItem,
                Income = (Income)addShop.IncomeCB.SelectedItem,
                Name = addShop.FirstNameTB.Text,
                IsAvailableProduct = addShop.IsAvailableProductCB.Checked
            };

            context.Shops.Add(shop);
            await context.SaveChangesAsync();
            MessageBox.Show("Shop was added");
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

                Shop shop = await context.Shops.FindAsync(id);

                AddEditShop addShop = new AddEditShop();

                addShop.FirstNameTB.Text = shop.Name;
                addShop.IsAvailableProductCB.Checked = shop.IsAvailableProduct;
                addShop.ProductCB.SelectedItem = shop.Product;
                addShop.IncomeCB.SelectedItem = shop.Income;

                addShop.ProductCB.DataSource = productes;
                addShop.ProductCB.ValueMember = "Id";
                addShop.ProductCB.DisplayMember = "Name";

                addShop.IncomeCB.DataSource = incomes;
                addShop.IncomeCB.ValueMember = "Id";
                addShop.IncomeCB.DisplayMember = "Date";

                DialogResult result = addShop.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                shop.Product = (Product)addShop.ProductCB.SelectedItem;
                shop.Income = (Income)addShop.IncomeCB.SelectedItem;
                shop.Name = addShop.FirstNameTB.Text;
                shop.IsAvailableProduct = addShop.IsAvailableProductCB.Checked;

                await context.SaveChangesAsync();
                MessageBox.Show("Shop was updated");
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

                Shop shop = await context.Shops.FindAsync(id);
                context.Shops.Remove(shop);
                await context.SaveChangesAsync();

                MessageBox.Show("Shop was deleted");
                dataGridView1.Refresh();
            }
        }

        private void MPButton_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            this.Hide();
            products.Show();
        }

        private void MIButton_Click(object sender, EventArgs e)
        {
            Incomes incomes = new Incomes();
            this.Hide();
            incomes.Show();
        }
    }
}
