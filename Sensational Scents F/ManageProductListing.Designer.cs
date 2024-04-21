namespace Sensational_Scents_F
{
    partial class ManageProductListing
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
            this.GvProductList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AddNewProductButton = new System.Windows.Forms.Button();
            this.EditProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.buttonrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // GvProductList
            // 
            this.GvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvProductList.Location = new System.Drawing.Point(12, 97);
            this.GvProductList.Name = "GvProductList";
            this.GvProductList.RowHeadersWidth = 51;
            this.GvProductList.Size = new System.Drawing.Size(776, 250);
            this.GvProductList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Product Listing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddNewProductButton
            // 
            this.AddNewProductButton.Location = new System.Drawing.Point(451, 369);
            this.AddNewProductButton.Name = "AddNewProductButton";
            this.AddNewProductButton.Size = new System.Drawing.Size(118, 44);
            this.AddNewProductButton.TabIndex = 2;
            this.AddNewProductButton.Text = "Add New Product";
            this.AddNewProductButton.UseVisualStyleBackColor = true;
            this.AddNewProductButton.Click += new System.EventHandler(this.AddNewProductButton_Click);
            // 
            // EditProductButton
            // 
            this.EditProductButton.Location = new System.Drawing.Point(652, 369);
            this.EditProductButton.Name = "EditProductButton";
            this.EditProductButton.Size = new System.Drawing.Size(118, 48);
            this.EditProductButton.TabIndex = 2;
            this.EditProductButton.Text = "Edit Product";
            this.EditProductButton.UseVisualStyleBackColor = true;
            this.EditProductButton.Click += new System.EventHandler(this.EditProductButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(40, 371);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(118, 42);
            this.DeleteProductButton.TabIndex = 3;
            this.DeleteProductButton.Text = "Delete Product";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // buttonrefresh
            // 
            this.buttonrefresh.Location = new System.Drawing.Point(218, 371);
            this.buttonrefresh.Name = "buttonrefresh";
            this.buttonrefresh.Size = new System.Drawing.Size(118, 42);
            this.buttonrefresh.TabIndex = 3;
            this.buttonrefresh.Text = "Refresh";
            this.buttonrefresh.UseVisualStyleBackColor = true;
            this.buttonrefresh.Click += new System.EventHandler(this.buttonrefresh_click);
            // 
            // ManageProductListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonrefresh);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.EditProductButton);
            this.Controls.Add(this.AddNewProductButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GvProductList);
            this.Name = "ManageProductListing";
            this.Text = "Manage Product Listing";
            this.Load += new System.EventHandler(this.ManageProductListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GvProductList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddNewProductButton;
        private System.Windows.Forms.Button EditProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button buttonrefresh;
    }
}