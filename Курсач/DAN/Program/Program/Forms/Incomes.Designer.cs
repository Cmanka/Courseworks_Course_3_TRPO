using Program.Model;

namespace Program.Forms
{
    partial class Incomes
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
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ToMenuButton = new System.Windows.Forms.Button();
            this.ToShopsButton = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isByThePieceDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.countSoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.isByThePieceDataGridViewCheckBoxColumn,
            this.countSoldDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.sellerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.incomeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(342, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataSource = typeof(Income);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.AddButton.Location = new System.Drawing.Point(12, 172);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(93, 29);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.EditButton.Location = new System.Drawing.Point(125, 172);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(93, 29);
            this.EditButton.TabIndex = 4;
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
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ToMenuButton
            // 
            this.ToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ToMenuButton.Location = new System.Drawing.Point(71, 214);
            this.ToMenuButton.Name = "ToMenuButton";
            this.ToMenuButton.Size = new System.Drawing.Size(93, 29);
            this.ToMenuButton.TabIndex = 6;
            this.ToMenuButton.Text = "To menu";
            this.ToMenuButton.UseVisualStyleBackColor = true;
            this.ToMenuButton.Click += new System.EventHandler(this.ToMenuButton_Click);
            // 
            // ToShopsButton
            // 
            this.ToShopsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ToShopsButton.Location = new System.Drawing.Point(184, 214);
            this.ToShopsButton.Name = "ToShopsButton";
            this.ToShopsButton.Size = new System.Drawing.Size(93, 29);
            this.ToShopsButton.TabIndex = 7;
            this.ToShopsButton.Text = "To shops";
            this.ToShopsButton.UseVisualStyleBackColor = true;
            this.ToShopsButton.Click += new System.EventHandler(this.ToShopsButton_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // isByThePieceDataGridViewCheckBoxColumn
            // 
            this.isByThePieceDataGridViewCheckBoxColumn.DataPropertyName = "IsByThePiece";
            this.isByThePieceDataGridViewCheckBoxColumn.HeaderText = "IsByThePiece";
            this.isByThePieceDataGridViewCheckBoxColumn.Name = "isByThePieceDataGridViewCheckBoxColumn";
            // 
            // countSoldDataGridViewTextBoxColumn
            // 
            this.countSoldDataGridViewTextBoxColumn.DataPropertyName = "CountSold";
            this.countSoldDataGridViewTextBoxColumn.HeaderText = "CountSold";
            this.countSoldDataGridViewTextBoxColumn.Name = "countSoldDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // sellerDataGridViewTextBoxColumn
            // 
            this.sellerDataGridViewTextBoxColumn.DataPropertyName = "Seller";
            this.sellerDataGridViewTextBoxColumn.HeaderText = "Seller";
            this.sellerDataGridViewTextBoxColumn.Name = "sellerDataGridViewTextBoxColumn";
            // 
            // Incomes
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
            this.Name = "Incomes";
            this.Text = "Incomes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource incomeBindingSource;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ToMenuButton;
        private System.Windows.Forms.Button ToShopsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isByThePieceDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countSoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerDataGridViewTextBoxColumn;
    }
}