using Program.Model;

namespace Program.Forms
{
    partial class Sellers
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
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ToMenuButton = new System.Windows.Forms.Button();
            this.sellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGetPassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGetPassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dataBirthDataGridViewTextBoxColumn,
            this.numberPassportDataGridViewTextBoxColumn,
            this.nameGetPassportDataGridViewTextBoxColumn,
            this.dataGetPassportDataGridViewTextBoxColumn,
            this.shopDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sellerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(342, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.AddButton.Location = new System.Drawing.Point(12, 175);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(93, 29);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.EditButton.Location = new System.Drawing.Point(127, 175);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(93, 29);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.RemoveButton.Location = new System.Drawing.Point(236, 175);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(93, 29);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ToMenuButton
            // 
            this.ToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ToMenuButton.Location = new System.Drawing.Point(102, 220);
            this.ToMenuButton.Name = "ToMenuButton";
            this.ToMenuButton.Size = new System.Drawing.Size(139, 29);
            this.ToMenuButton.TabIndex = 7;
            this.ToMenuButton.Text = "To menu";
            this.ToMenuButton.UseVisualStyleBackColor = true;
            this.ToMenuButton.Click += new System.EventHandler(this.ToMenuButton_Click);
            // 
            // sellerBindingSource
            // 
            this.sellerBindingSource.DataSource = typeof(Seller);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // dataBirthDataGridViewTextBoxColumn
            // 
            this.dataBirthDataGridViewTextBoxColumn.DataPropertyName = "DataBirth";
            this.dataBirthDataGridViewTextBoxColumn.HeaderText = "DataBirth";
            this.dataBirthDataGridViewTextBoxColumn.Name = "dataBirthDataGridViewTextBoxColumn";
            // 
            // numberPassportDataGridViewTextBoxColumn
            // 
            this.numberPassportDataGridViewTextBoxColumn.DataPropertyName = "NumberPassport";
            this.numberPassportDataGridViewTextBoxColumn.HeaderText = "NumberPassport";
            this.numberPassportDataGridViewTextBoxColumn.Name = "numberPassportDataGridViewTextBoxColumn";
            // 
            // nameGetPassportDataGridViewTextBoxColumn
            // 
            this.nameGetPassportDataGridViewTextBoxColumn.DataPropertyName = "NameGetPassport";
            this.nameGetPassportDataGridViewTextBoxColumn.HeaderText = "NameGetPassport";
            this.nameGetPassportDataGridViewTextBoxColumn.Name = "nameGetPassportDataGridViewTextBoxColumn";
            // 
            // dataGetPassportDataGridViewTextBoxColumn
            // 
            this.dataGetPassportDataGridViewTextBoxColumn.DataPropertyName = "DataGetPassport";
            this.dataGetPassportDataGridViewTextBoxColumn.HeaderText = "DataGetPassport";
            this.dataGetPassportDataGridViewTextBoxColumn.Name = "dataGetPassportDataGridViewTextBoxColumn";
            // 
            // shopDataGridViewTextBoxColumn
            // 
            this.shopDataGridViewTextBoxColumn.DataPropertyName = "Shop";
            this.shopDataGridViewTextBoxColumn.HeaderText = "Shop";
            this.shopDataGridViewTextBoxColumn.Name = "shopDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // Sellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 255);
            this.Controls.Add(this.ToMenuButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sellers";
            this.Text = "Sellers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ToMenuButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGetPassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGetPassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sellerBindingSource;
    }
}