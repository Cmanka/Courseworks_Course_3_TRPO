using Program.Model;
namespace Program.Forms
{
    partial class Shops
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.MIButton = new System.Windows.Forms.Button();
            this.MPButton = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvailableProductDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.isAvailableProductDataGridViewCheckBoxColumn,
            this.incomeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shopBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(439, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // shopBindingSource
            // 
            this.shopBindingSource.DataSource = typeof(Shop);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.AddButton.Location = new System.Drawing.Point(21, 170);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(113, 30);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.EditButton.Location = new System.Drawing.Point(165, 170);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(113, 30);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.RemoveButton.Location = new System.Drawing.Point(303, 170);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(113, 30);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.BackButton.Location = new System.Drawing.Point(165, 215);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(113, 30);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MIButton
            // 
            this.MIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.MIButton.Location = new System.Drawing.Point(303, 208);
            this.MIButton.Name = "MIButton";
            this.MIButton.Size = new System.Drawing.Size(113, 44);
            this.MIButton.TabIndex = 5;
            this.MIButton.Text = "Manage Incomes";
            this.MIButton.UseVisualStyleBackColor = true;
            this.MIButton.Click += new System.EventHandler(this.MIButton_Click);
            // 
            // MPButton
            // 
            this.MPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.MPButton.Location = new System.Drawing.Point(21, 208);
            this.MPButton.Name = "MPButton";
            this.MPButton.Size = new System.Drawing.Size(113, 44);
            this.MPButton.TabIndex = 6;
            this.MPButton.Text = "Manage Products";
            this.MPButton.UseVisualStyleBackColor = true;
            this.MPButton.Click += new System.EventHandler(this.MPButton_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // isAvailableProductDataGridViewCheckBoxColumn
            // 
            this.isAvailableProductDataGridViewCheckBoxColumn.DataPropertyName = "IsAvailableProduct";
            this.isAvailableProductDataGridViewCheckBoxColumn.HeaderText = "IsAvailableProduct";
            this.isAvailableProductDataGridViewCheckBoxColumn.Name = "isAvailableProductDataGridViewCheckBoxColumn";
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "Income";
            this.incomeDataGridViewTextBoxColumn.HeaderText = "Income";
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            // 
            // Shops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 257);
            this.Controls.Add(this.MPButton);
            this.Controls.Add(this.MIButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Shops";
            this.Text = "Shops";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource shopBindingSource;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button MIButton;
        private System.Windows.Forms.Button MPButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAvailableProductDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
    }
}