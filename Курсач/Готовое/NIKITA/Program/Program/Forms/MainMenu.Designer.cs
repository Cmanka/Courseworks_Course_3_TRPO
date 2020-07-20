namespace Program.Forms
{
    partial class MainMenu
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
            this.MastersButton = new System.Windows.Forms.Button();
            this.ServicesButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MastersButton
            // 
            this.MastersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.MastersButton.Location = new System.Drawing.Point(45, 22);
            this.MastersButton.Name = "MastersButton";
            this.MastersButton.Size = new System.Drawing.Size(163, 45);
            this.MastersButton.TabIndex = 0;
            this.MastersButton.Text = "Управление мастерами";
            this.MastersButton.UseVisualStyleBackColor = true;
            this.MastersButton.Click += new System.EventHandler(this.MastersButton_Click);
            // 
            // ServicesButton
            // 
            this.ServicesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ServicesButton.Location = new System.Drawing.Point(45, 84);
            this.ServicesButton.Name = "ServicesButton";
            this.ServicesButton.Size = new System.Drawing.Size(163, 49);
            this.ServicesButton.TabIndex = 1;
            this.ServicesButton.Text = "Управление услугами";
            this.ServicesButton.UseVisualStyleBackColor = true;
            this.ServicesButton.Click += new System.EventHandler(this.ServicesButton_Click);
            // 
            // ClientsButton
            // 
            this.ClientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ClientsButton.Location = new System.Drawing.Point(45, 149);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(163, 45);
            this.ClientsButton.TabIndex = 2;
            this.ClientsButton.Text = "Управление клиентами";
            this.ClientsButton.UseVisualStyleBackColor = true;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ExitButton.Location = new System.Drawing.Point(45, 211);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(163, 39);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(248, 262);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClientsButton);
            this.Controls.Add(this.ServicesButton);
            this.Controls.Add(this.MastersButton);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MastersButton;
        private System.Windows.Forms.Button ServicesButton;
        private System.Windows.Forms.Button ClientsButton;
        private System.Windows.Forms.Button ExitButton;
    }
}