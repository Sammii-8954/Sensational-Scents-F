namespace Sensational_Scents_F
{
    partial class ManageProductRecords
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
            this.buttonrefresh_archive = new System.Windows.Forms.Button();
            this.DeleteRecordButton = new System.Windows.Forms.Button();
            this.EditRecordButton = new System.Windows.Forms.Button();
            this.AddNewRecordButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GvRecordList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GvRecordList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonrefresh_archive
            // 
            this.buttonrefresh_archive.Location = new System.Drawing.Point(218, 376);
            this.buttonrefresh_archive.Name = "buttonrefresh_archive";
            this.buttonrefresh_archive.Size = new System.Drawing.Size(118, 42);
            this.buttonrefresh_archive.TabIndex = 8;
            this.buttonrefresh_archive.Text = "Refresh";
            this.buttonrefresh_archive.UseVisualStyleBackColor = true;
            this.buttonrefresh_archive.Click += new System.EventHandler(this.buttonrefresh_archive_Click);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(40, 376);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(118, 42);
            this.DeleteRecordButton.TabIndex = 9;
            this.DeleteRecordButton.Text = "Delete Record";
            this.DeleteRecordButton.UseVisualStyleBackColor = true;
            this.DeleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // EditRecordButton
            // 
            this.EditRecordButton.Location = new System.Drawing.Point(652, 374);
            this.EditRecordButton.Name = "EditRecordButton";
            this.EditRecordButton.Size = new System.Drawing.Size(118, 48);
            this.EditRecordButton.TabIndex = 6;
            this.EditRecordButton.Text = "Edit Record";
            this.EditRecordButton.UseVisualStyleBackColor = true;
            this.EditRecordButton.Click += new System.EventHandler(this.EditRecordButton_Click);
            // 
            // AddNewRecordButton
            // 
            this.AddNewRecordButton.Location = new System.Drawing.Point(451, 374);
            this.AddNewRecordButton.Name = "AddNewRecordButton";
            this.AddNewRecordButton.Size = new System.Drawing.Size(118, 44);
            this.AddNewRecordButton.TabIndex = 7;
            this.AddNewRecordButton.Text = "Add New Record";
            this.AddNewRecordButton.UseVisualStyleBackColor = true;
            this.AddNewRecordButton.Click += new System.EventHandler(this.AddNewRecordButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 70);
            this.label1.TabIndex = 5;
            this.label1.Text = "Manage Product Records";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GvRecordList
            // 
            this.GvRecordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvRecordList.Location = new System.Drawing.Point(12, 102);
            this.GvRecordList.Name = "GvRecordList";
            this.GvRecordList.RowHeadersWidth = 51;
            this.GvRecordList.Size = new System.Drawing.Size(776, 250);
            this.GvRecordList.TabIndex = 4;
            // 
            // ManageProductRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonrefresh_archive);
            this.Controls.Add(this.DeleteRecordButton);
            this.Controls.Add(this.EditRecordButton);
            this.Controls.Add(this.AddNewRecordButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GvRecordList);
            this.Name = "ManageProductRecords";
            this.Text = "ManageProductRecords";
            this.Load += new System.EventHandler(this.ManageProductRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvRecordList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonrefresh_archive;
        private System.Windows.Forms.Button DeleteRecordButton;
        private System.Windows.Forms.Button EditRecordButton;
        private System.Windows.Forms.Button AddNewRecordButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GvRecordList;
    }
}