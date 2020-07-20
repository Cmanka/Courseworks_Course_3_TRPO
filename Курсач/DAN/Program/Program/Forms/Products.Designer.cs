using Program.Model;

namespace Program.Forms
{
    partial class Products
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
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ToMenuButton = new System.Windows.Forms.Button();
            this.ToShopsButton = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isByThePieceDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.isByThePieceDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(342, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Product);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.AddButton.Location = new System.Drawing.Point(12, 172);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(93, 29);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.EditButton.Location = new System.Drawing.Point(124, 172);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(93, 29);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.RemoveButton.Location = new System.Drawing.Point(236, 172);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(93, 29);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ToMenuButton
            // 
            this.ToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ToMenuButton.Location = new System.Drawing.Point(73, 214);
            this.ToMenuButton.Name = "ToMenuButton";
            this.ToMenuButton.Size = new System.Drawing.Size(93, 29);
            this.ToMenuButton.TabIndex = 5;
            this.ToMenuButton.Text = "To menu";
            this.ToMenuButton.UseVisualStyleBackColor = true;
            this.ToMenuButton.Click += new System.EventHandler(this.ToMenuButton_Click);
            // 
            // ToShopsButton
            // 
            this.ToShopsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ToShopsButton.Location = new System.Drawing.Point(183, 214);
            this.ToShopsButton.Name = "ToShopsButton";
            this.ToShopsButton.Size = new System.Drawing.Size(93, 29);
            this.ToShopsButton.TabIndex = 6;
            this.ToShopsButton.Text = "To shops";
            this.ToShopsButton.UseVisualStyleBackColor = true;
            this.ToShopsButton.Click += new System.EventHandler(this.ToShopsButton_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // isByThePieceDataGridViewCheckBoxColumn
            // 
            this.isByThePieceDataGridViewCheckBoxColumn.DataPropertyName = "IsByThePiece";
            this.isByThePieceDataGridViewCheckBoxColumn.HeaderText = "IsByThePiece";
            this.isByThePieceDataGridViewCheckBoxColumn.Name = "isByThePieceDataGridViewCheckBoxColumn";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 255);
            this.Controls.Add(this.ToShopsButton);
            this.Controls.Add(this.ToMenuButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ToMenuButton;
        private System.Windows.Forms.Button ToShopsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isByThePieceDataGridViewCheckBoxColumn;
    }
}