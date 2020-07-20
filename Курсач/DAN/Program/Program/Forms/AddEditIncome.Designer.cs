namespace Program.Forms
{
    partial class AddEditIncome
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
            this.label1 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            this.IsByThePriceCB = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CountSoldOutBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductCB = new System.Windows.Forms.ComboBox();
            this.SellerBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CountSoldOutBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date";
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.OkButton.Location = new System.Drawing.Point(12, 322);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(153, 34);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(12, 32);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(153, 20);
            this.DateBox.TabIndex = 6;
            // 
            // IsByThePriceCB
            // 
            this.IsByThePriceCB.AutoSize = true;
            this.IsByThePriceCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.IsByThePriceCB.Location = new System.Drawing.Point(12, 94);
            this.IsByThePriceCB.Name = "IsByThePriceCB";
            this.IsByThePriceCB.Size = new System.Drawing.Size(161, 24);
            this.IsByThePriceCB.TabIndex = 10;
            this.IsByThePriceCB.Text = "Yes(By the piece)";
            this.IsByThePriceCB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "IsByThePiece";
            // 
            // CountSoldOutBox
            // 
            this.CountSoldOutBox.Location = new System.Drawing.Point(12, 154);
            this.CountSoldOutBox.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.CountSoldOutBox.Name = "CountSoldOutBox";
            this.CountSoldOutBox.Size = new System.Drawing.Size(153, 20);
            this.CountSoldOutBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(8, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Count sold out";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(8, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(8, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Seller";
            // 
            // ProductCB
            // 
            this.ProductCB.FormattingEnabled = true;
            this.ProductCB.Location = new System.Drawing.Point(12, 214);
            this.ProductCB.Name = "ProductCB";
            this.ProductCB.Size = new System.Drawing.Size(153, 21);
            this.ProductCB.TabIndex = 17;
            // 
            // SellerBox
            // 
            this.SellerBox.FormattingEnabled = true;
            this.SellerBox.Location = new System.Drawing.Point(12, 283);
            this.SellerBox.Name = "SellerBox";
            this.SellerBox.Size = new System.Drawing.Size(153, 21);
            this.SellerBox.TabIndex = 18;
            // 
            // AddEditIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 368);
            this.Controls.Add(this.SellerBox);
            this.Controls.Add(this.ProductCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CountSoldOutBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IsByThePriceCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label1);
            this.Name = "AddEditIncome";
            this.Text = "AddEditIncome";
            ((System.ComponentModel.ISupportInitialize)(this.CountSoldOutBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkButton;
        protected internal System.Windows.Forms.CheckBox IsByThePriceCB;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.NumericUpDown CountSoldOutBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.DateTimePicker DateBox;
        protected internal System.Windows.Forms.ComboBox ProductCB;
        protected internal System.Windows.Forms.ComboBox SellerBox;
    }
}