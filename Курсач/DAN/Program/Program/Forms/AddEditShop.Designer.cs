namespace Program.Forms
{
    partial class AddEditShop
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
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IsAvailableProductCB = new System.Windows.Forms.CheckBox();
            this.ProductCB = new System.Windows.Forms.ComboBox();
            this.IncomeCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Location = new System.Drawing.Point(12, 32);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(153, 20);
            this.FirstNameTB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.OkButton.Location = new System.Drawing.Point(12, 284);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(153, 34);
            this.OkButton.TabIndex = 20;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "IsAvailableProduct";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(8, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(8, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Income";
            // 
            // IsAvailableProductCB
            // 
            this.IsAvailableProductCB.AutoSize = true;
            this.IsAvailableProductCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.IsAvailableProductCB.Location = new System.Drawing.Point(12, 94);
            this.IsAvailableProductCB.Name = "IsAvailableProductCB";
            this.IsAvailableProductCB.Size = new System.Drawing.Size(212, 24);
            this.IsAvailableProductCB.TabIndex = 28;
            this.IsAvailableProductCB.Text = "Yes(product is available)";
            this.IsAvailableProductCB.UseVisualStyleBackColor = true;
            // 
            // ProductCB
            // 
            this.ProductCB.FormattingEnabled = true;
            this.ProductCB.Location = new System.Drawing.Point(12, 151);
            this.ProductCB.Name = "ProductCB";
            this.ProductCB.Size = new System.Drawing.Size(153, 21);
            this.ProductCB.TabIndex = 29;
            // 
            // IncomeCB
            // 
            this.IncomeCB.FormattingEnabled = true;
            this.IncomeCB.Location = new System.Drawing.Point(12, 216);
            this.IncomeCB.Name = "IncomeCB";
            this.IncomeCB.Size = new System.Drawing.Size(153, 21);
            this.IncomeCB.TabIndex = 30;
            // 
            // AddEditShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 330);
            this.Controls.Add(this.IncomeCB);
            this.Controls.Add(this.ProductCB);
            this.Controls.Add(this.IsAvailableProductCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.FirstNameTB);
            this.Controls.Add(this.label1);
            this.Name = "AddEditShop";
            this.Text = "AddEditShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.CheckBox IsAvailableProductCB;
        protected internal System.Windows.Forms.ComboBox ProductCB;
        protected internal System.Windows.Forms.ComboBox IncomeCB;
    }
}