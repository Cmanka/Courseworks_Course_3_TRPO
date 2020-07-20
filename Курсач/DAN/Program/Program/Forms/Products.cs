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
    public partial class Products : Form
    {
        MyAppContext context;
        public Products()
        {
            InitializeComponent();
            context = new MyAppContext();
            context.Product.Load();
            dataGridView1.DataSource = context.Product.Local.ToBindingList();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            AddEditProduct addProduct = new AddEditProduct();
            DialogResult result = addProduct.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;
            if (addProduct.NameTB.Text == "")
            {
                MessageBox.Show("Name field is empty");
                return;
            }
            Product product = new Product()
            {
                Name = addProduct.NameTB.Text,
                Price = (float)addProduct.PriceTB.Value,
                IsByThePiece = addProduct.IsByThePriceCB.Checked
            };

            context.Product.Add(product);

            await context.SaveChangesAsync();
            MessageBox.Show("Product was added");
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

                Product product = await context.Product.FindAsync(id);

                AddEditProduct addProduct = new AddEditProduct();

                addProduct.NameTB.Text = product.Name;
                addProduct.PriceTB.Value = (decimal)product.Price;
                addProduct.IsByThePriceCB.Checked = product.IsByThePiece;

                DialogResult result = addProduct.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;
                if (addProduct.NameTB.Text =="")
                {
                    MessageBox.Show("Name field is empty");
                    return;
                }
                product.Name = addProduct.NameTB.Text;
                product.Price = (float)addProduct.PriceTB.Value;
                product.IsByThePiece = addProduct.IsByThePriceCB.Checked;

                await context.SaveChangesAsync();
                MessageBox.Show("Product was updated");
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

                Product product = await context.Product.FindAsync(id);
                context.Product.Remove(product);
                await context.SaveChangesAsync();

                MessageBox.Show("Product was deleted");
                dataGridView1.Refresh();
            }
        }

        private void ToMenuButton_Click(object sender, EventArgs e)
        {
            Forms.Menu menu = new Forms.Menu();
            this.Hide();
            menu.Show();
        }

        private void ToShopsButton_Click(object sender, EventArgs e)
        {
            Shops shop = new Shops();
            this.Hide();
            shop.Show();
        }
    }
}
