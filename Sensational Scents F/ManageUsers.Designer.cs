namespace Sensational_Scents_F
{
    partial class ManageUsers
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
            this.buttonaddnewusers = new System.Windows.Forms.Button();
            this.ManageUSersLabel = new System.Windows.Forms.Label();
            this.GvUserList = new System.Windows.Forms.DataGridView();
            this.resetpasswordbutton = new System.Windows.Forms.Button();
            this.buttondeactivateuser = new System.Windows.Forms.Button();
            this.refreshbuton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonaddnewusers
            // 
            this.buttonaddnewusers.Location = new System.Drawing.Point(23, 378);
            this.buttonaddnewusers.Name = "buttonaddnewusers";
            this.buttonaddnewusers.Size = new System.Drawing.Size(118, 42);
            this.buttonaddnewusers.TabIndex = 6;
            this.buttonaddnewusers.Text = "AddNew User";
            this.buttonaddnewusers.UseVisualStyleBackColor = true;
            this.buttonaddnewusers.Click += new System.EventHandler(this.buttonaddnewusers_Click);
            // 
            // ManageUSersLabel
            // 
            this.ManageUSersLabel.AutoSize = true;
            this.ManageUSersLabel.Font = new System.Drawing.Font("Vivaldi", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageUSersLabel.Location = new System.Drawing.Point(177, 31);
            this.ManageUSersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManageUSersLabel.Name = "ManageUSersLabel";
            this.ManageUSersLabel.Size = new System.Drawing.Size(374, 70);
            this.ManageUSersLabel.TabIndex = 5;
            this.ManageUSersLabel.Text = "Manage Users";
            this.ManageUSersLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GvUserList
            // 
            this.GvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvUserList.Location = new System.Drawing.Point(12, 104);
            this.GvUserList.Name = "GvUserList";
            this.GvUserList.RowHeadersWidth = 51;
            this.GvUserList.Size = new System.Drawing.Size(776, 250);
            this.GvUserList.TabIndex = 4;
            // 
            // resetpasswordbutton
            // 
            this.resetpasswordbutton.Location = new System.Drawing.Point(253, 378);
            this.resetpasswordbutton.Name = "resetpasswordbutton";
            this.resetpasswordbutton.Size = new System.Drawing.Size(118, 42);
            this.resetpasswordbutton.TabIndex = 6;
            this.resetpasswordbutton.Text = "Reset Password";
            this.resetpasswordbutton.UseVisualStyleBackColor = true;
            this.resetpasswordbutton.Click += new System.EventHandler(this.resetpasswordbutton_Click);
            // 
            // buttondeactivateuser
            // 
            this.buttondeactivateuser.Location = new System.Drawing.Point(454, 378);
            this.buttondeactivateuser.Name = "buttondeactivateuser";
            this.buttondeactivateuser.Size = new System.Drawing.Size(118, 42);
            this.buttondeactivateuser.TabIndex = 6;
            this.buttondeactivateuser.Text = "Deactivate";
            this.buttondeactivateuser.UseVisualStyleBackColor = true;
            this.buttondeactivateuser.Click += new System.EventHandler(this.buttondeactivateuser_Click);
            // 
            // refreshbuton
            // 
            this.refreshbuton.Location = new System.Drawing.Point(644, 378);
            this.refreshbuton.Name = "refreshbuton";
            this.refreshbuton.Size = new System.Drawing.Size(118, 42);
            this.refreshbuton.TabIndex = 6;
            this.refreshbuton.Text = "Refresh";
            this.refreshbuton.UseVisualStyleBackColor = true;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refreshbuton);
            this.Controls.Add(this.buttondeactivateuser);
            this.Controls.Add(this.resetpasswordbutton);
            this.Controls.Add(this.buttonaddnewusers);
            this.Controls.Add(this.ManageUSersLabel);
            this.Controls.Add(this.GvUserList);
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            ((System.ComponentModel.ISupportInitialize)(this.GvUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonaddnewusers;
        private System.Windows.Forms.Label ManageUSersLabel;
        private System.Windows.Forms.DataGridView GvUserList;
        private System.Windows.Forms.Button resetpasswordbutton;
        private System.Windows.Forms.Button buttondeactivateuser;
        private System.Windows.Forms.Button refreshbuton;
    }
}