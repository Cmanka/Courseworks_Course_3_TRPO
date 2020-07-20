namespace Program.Forms
{
    partial class AddEditProduct
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
            this.OkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceTB = new System.Windows.Forms.NumericUpDown();
            this.IsByThePriceCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PriceTB)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.OkButton.Location = new System.Drawing.Point(12, 204);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(153, 34);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(12, 34);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(153, 20);
            this.NameTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(8, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(8, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "IsByThePiece";
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(12, 105);
            this.PriceTB.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(153, 20);
            this.PriceTB.TabIndex = 7;
            // 
            // IsByThePriceCB
            // 
            this.IsByThePriceCB.AutoSize = true;
            this.IsByThePriceCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.IsByThePriceCB.Location = new System.Drawing.Point(12, 170);
            this.IsByThePriceCB.Name = "IsByThePriceCB";
            this.IsByThePriceCB.Size = new System.Drawing.Size(161, 24);
            this.IsByThePriceCB.TabIndex = 8;
            this.IsByThePriceCB.Text = "Yes(By the piece)";
            this.IsByThePriceCB.UseVisualStyleBackColor = true;
            // 
            // AddEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 250);
            this.Controls.Add(this.IsByThePriceCB);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkButton);
            this.Name = "AddEditProduct";
            this.Text = "AddEditProduct";
            ((System.ComponentModel.ISupportInitialize)(this.PriceTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.TextBox NameTB;
        protected internal System.Windows.Forms.NumericUpDown PriceTB;
        protected internal System.Windows.Forms.CheckBox IsByThePriceCB;
    }
}