namespace Program.Forms
{
    partial class AddEditMaster
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberTB = new System.Windows.Forms.NumericUpDown();
            this.MaterialCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumberTB)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(36, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(35, 36);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(93, 20);
            this.NameTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(32, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Материал";
            // 
            // NumberTB
            // 
            this.NumberTB.Location = new System.Drawing.Point(36, 100);
            this.NumberTB.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.NumberTB.Name = "NumberTB";
            this.NumberTB.Size = new System.Drawing.Size(92, 20);
            this.NumberTB.TabIndex = 7;
            // 
            // MaterialCB
            // 
            this.MaterialCB.AutoSize = true;
            this.MaterialCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.MaterialCB.Location = new System.Drawing.Point(35, 165);
            this.MaterialCB.Name = "MaterialCB";
            this.MaterialCB.Size = new System.Drawing.Size(107, 22);
            this.MaterialCB.TabIndex = 8;
            this.MaterialCB.Text = "Да(+)Нет(-)";
            this.MaterialCB.UseVisualStyleBackColor = true;
            // 
            // AddEditMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(162, 262);
            this.Controls.Add(this.MaterialCB);
            this.Controls.Add(this.NumberTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "AddEditMaster";
            this.Text = "AddEditMaster";
            ((System.ComponentModel.ISupportInitialize)(this.NumberTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.CheckBox MaterialCB;
        protected internal System.Windows.Forms.NumericUpDown NumberTB;
        protected internal System.Windows.Forms.TextBox NameTB;
    }
}