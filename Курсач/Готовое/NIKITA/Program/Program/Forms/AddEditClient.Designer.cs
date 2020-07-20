namespace Program.Forms
{
    partial class AddEditClient
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
            this.FirstnameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SecondnameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastnameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumberTB = new System.Windows.Forms.NumericUpDown();
            this.dataTB = new System.Windows.Forms.DateTimePicker();
            this.ServiceCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumberTB)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstnameTB
            // 
            this.FirstnameTB.Location = new System.Drawing.Point(33, 33);
            this.FirstnameTB.Name = "FirstnameTB";
            this.FirstnameTB.Size = new System.Drawing.Size(93, 20);
            this.FirstnameTB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(30, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(34, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SecondnameTB
            // 
            this.SecondnameTB.Location = new System.Drawing.Point(33, 86);
            this.SecondnameTB.Name = "SecondnameTB";
            this.SecondnameTB.Size = new System.Drawing.Size(93, 20);
            this.SecondnameTB.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(30, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Фамилия";
            // 
            // LastnameTB
            // 
            this.LastnameTB.Location = new System.Drawing.Point(33, 140);
            this.LastnameTB.Name = "LastnameTB";
            this.LastnameTB.Size = new System.Drawing.Size(93, 20);
            this.LastnameTB.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(30, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(30, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Номер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(30, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дата и время ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(30, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Услуга";
            // 
            // NumberTB
            // 
            this.NumberTB.Location = new System.Drawing.Point(33, 197);
            this.NumberTB.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.NumberTB.Name = "NumberTB";
            this.NumberTB.Size = new System.Drawing.Size(93, 20);
            this.NumberTB.TabIndex = 18;
            // 
            // dataTB
            // 
            this.dataTB.Location = new System.Drawing.Point(33, 246);
            this.dataTB.Name = "dataTB";
            this.dataTB.Size = new System.Drawing.Size(93, 20);
            this.dataTB.TabIndex = 19;
            // 
            // ServiceCB
            // 
            this.ServiceCB.FormattingEnabled = true;
            this.ServiceCB.Location = new System.Drawing.Point(33, 303);
            this.ServiceCB.Name = "ServiceCB";
            this.ServiceCB.Size = new System.Drawing.Size(93, 21);
            this.ServiceCB.TabIndex = 20;
            // 
            // AddEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(162, 389);
            this.Controls.Add(this.ServiceCB);
            this.Controls.Add(this.dataTB);
            this.Controls.Add(this.NumberTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastnameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecondnameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FirstnameTB);
            this.Controls.Add(this.label1);
            this.Name = "AddEditClient";
            this.Text = "AddEditClient";
            ((System.ComponentModel.ISupportInitialize)(this.NumberTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.TextBox FirstnameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        protected internal System.Windows.Forms.TextBox SecondnameTB;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.TextBox LastnameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        protected internal System.Windows.Forms.NumericUpDown NumberTB;
        protected internal System.Windows.Forms.DateTimePicker dataTB;
        protected internal System.Windows.Forms.ComboBox ServiceCB;
    }
}