namespace Program.Formes
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
            this.ExibitionsButton = new System.Windows.Forms.Button();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExibitionsButton
            // 
            this.ExibitionsButton.Location = new System.Drawing.Point(47, 23);
            this.ExibitionsButton.Name = "ExibitionsButton";
            this.ExibitionsButton.Size = new System.Drawing.Size(206, 36);
            this.ExibitionsButton.TabIndex = 0;
            this.ExibitionsButton.Text = "Работа с выставками";
            this.ExibitionsButton.UseVisualStyleBackColor = true;
            this.ExibitionsButton.Click += new System.EventHandler(this.ExibitionsButton_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.Location = new System.Drawing.Point(46, 114);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(206, 36);
            this.ReportsButton.TabIndex = 1;
            this.ReportsButton.Text = "Работа с отчётами";
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(46, 200);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(206, 36);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 264);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.ExibitionsButton);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExibitionsButton;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.Button ExitButton;
    }
}