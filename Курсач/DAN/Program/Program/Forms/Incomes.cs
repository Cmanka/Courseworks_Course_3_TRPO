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
    public partial class Incomes : Form
    {
        MyAppContext context;
        List<Product> products;
        List<Seller> sellers;
        public Incomes()
        {
            InitializeComponent();
            context = new MyAppContext();
            products = context.Product.ToList();
            sellers = context.Selleres.ToList();
            context.Incomes.Load();
            dataGridView1.DataSource = context.Incomes.Local.ToBindingList();
            dataGridView1.Refresh();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            AddEditIncome addIncome = new AddEditIncome();

            addIncome.ProductCB.DataSource = products;
            addIncome.ProductCB.ValueMember = "Id";
            addIncome.ProductCB.DisplayMember = "Name";

            addIncome.SellerBox.DataSource = sellers;
            addIncome.SellerBox.ValueMember = "Id";
            addIncome.SellerBox.DisplayMember = "Firstname";

            DialogResult result = addIncome.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Income income = new Income()
            {
                Product = (Product)addIncome.ProductCB.SelectedItem,
                Seller = (Seller)addIncome.SellerBox.SelectedItem,
                Date = addIncome.DateBox.Value,
                CountSold = (int)addIncome.CountSoldOutBox.Value,
                IsByThePiece = addIncome.IsByThePriceCB.Checked
            };

            context.Incomes.Add(income);
            await context.SaveChangesAsync();
            MessageBox.Show("Income was added");
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

                Income income = await context.Incomes.FindAsync(id);

                AddEditIncome addIncome = new AddEditIncome();

                addIncome.DateBox.Value = income.Date;
                addIncome.IsByThePriceCB.Checked = income.IsByThePiece;
                addIncome.CountSoldOutBox.Value = income.CountSold;
                addIncome.ProductCB.SelectedItem = income.Product;
                addIncome.SellerBox.SelectedItem = income.Seller;

                addIncome.ProductCB.DataSource = products;
                addIncome.ProductCB.ValueMember = "Id";
                addIncome.ProductCB.DisplayMember = "Name";

                addIncome.SellerBox.DataSource = sellers;
                addIncome.SellerBox.ValueMember = "Id";
                addIncome.SellerBox.DisplayMember = "Surname";

                DialogResult result = addIncome.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                income.Product = (Product)addIncome.ProductCB.SelectedItem;
                income.Seller = (Seller)addIncome.SellerBox.SelectedItem;
                income.Date = addIncome.DateBox.Value;
                income.CountSold = (int)addIncome.CountSoldOutBox.Value;
                income.IsByThePiece = addIncome.IsByThePriceCB.Checked;

                await context.SaveChangesAsync();
                MessageBox.Show("Income was updated");
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

                Income income = await context.Incomes.FindAsync(id);
                context.Incomes.Remove(income);
                await context.SaveChangesAsync();

                MessageBox.Show("Income was deleted");
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
