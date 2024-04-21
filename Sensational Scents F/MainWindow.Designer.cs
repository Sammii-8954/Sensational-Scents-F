namespace Sensational_Scents_F
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCustomerRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerRecodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewArchivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomerRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.manageCustomerRecordsToolStripMenuItem,
            this.manageUsersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.manageToolStripMenuItem.Text = "Manage Product Listing";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // manageCustomerRecordsToolStripMenuItem
            // 
            this.manageCustomerRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerRecodsToolStripMenuItem,
            this.viewArchivesToolStripMenuItem,
            this.editCustomerRecordsToolStripMenuItem});
            this.manageCustomerRecordsToolStripMenuItem.Name = "manageCustomerRecordsToolStripMenuItem";
            this.manageCustomerRecordsToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.manageCustomerRecordsToolStripMenuItem.Text = "Manage Customer Orders";
            // 
            // addCustomerRecodsToolStripMenuItem
            // 
            this.addCustomerRecodsToolStripMenuItem.Name = "addCustomerRecodsToolStripMenuItem";
            this.addCustomerRecodsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.addCustomerRecodsToolStripMenuItem.Text = "Add Customer Orders";
            this.addCustomerRecodsToolStripMenuItem.Click += new System.EventHandler(this.addCustomerRecodsToolStripMenuItem_Click);
            // 
            // viewArchivesToolStripMenuItem
            // 
            this.viewArchivesToolStripMenuItem.Name = "viewArchivesToolStripMenuItem";
            this.viewArchivesToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.viewArchivesToolStripMenuItem.Text = "View Archives";
            this.viewArchivesToolStripMenuItem.Click += new System.EventHandler(this.viewArchivesToolStripMenuItem_Click);
            // 
            // editCustomerRecordsToolStripMenuItem
            // 
            this.editCustomerRecordsToolStripMenuItem.Name = "editCustomerRecordsToolStripMenuItem";
            this.editCustomerRecordsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.editCustomerRecordsToolStripMenuItem.Text = "Edit Customer Orders";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Sensational Scents";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCustomerRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerRecodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewArchivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCustomerRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
    }
}