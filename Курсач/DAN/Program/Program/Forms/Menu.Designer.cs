namespace Program.Forms
{
    partial class Menu
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.MSellersButton = new System.Windows.Forms.Button();
            this.MShopsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ExitButton.Location = new System.Drawing.Point(25, 155);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(151, 30);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MSellersButton
            // 
            this.MSellersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.MSellersButton.Location = new System.Drawing.Point(25, 86);
            this.MSellersButton.Name = "MSellersButton";
            this.MSellersButton.Size = new System.Drawing.Size(151, 30);
            this.MSellersButton.TabIndex = 1;
            this.MSellersButton.Text = "Manage Sellers";
            this.MSellersButton.UseVisualStyleBackColor = true;
            this.MSellersButton.Click += new System.EventHandler(this.MSellersButton_Click);
            // 
            // MShopsButton
            // 
            this.MShopsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.MShopsButton.Location = new System.Drawing.Point(25, 16);
            this.MShopsButton.Name = "MShopsButton";
            this.MShopsButton.Size = new System.Drawing.Size(151, 30);
            this.MShopsButton.TabIndex = 2;
            this.MShopsButton.Text = "Manage Shops";
            this.MShopsButton.UseVisualStyleBackColor = true;
            this.MShopsButton.Click += new System.EventHandler(this.MShopsButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.MShopsButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.MSellersButton);
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 198);
            this.panel1.TabIndex = 3;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 227);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MSellersButton;
        private System.Windows.Forms.Button MShopsButton;
        private System.Windows.Forms.Panel panel1;
    }
}