using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sensational_Scents_F
{
    public partial class ManageProductListing : Form
    {
        private readonly Sensational_ScentsEntities _db;
        public ManageProductListing()
        {
            InitializeComponent();
            _db = new Sensational_ScentsEntities();
        }

        private void ManageProductListing_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            // var products = _db.TypesofProductsUpdateds.ToList();
            //  var products = _db.TypesofProductsUpdateds.Select(S => new { PRODUCTID = S.id, NAME = S.name }).ToList();


            var products = _db.TypesofProductsUpdateds.Select(s => new { Id = s.id, Name = s.name, Scent = s.scents, Type = s.type, Size = s.size }).ToList();

            GvProductList.DataSource = products;
           
          //  GvProductList.Columns[0].HeaderText = "ID";
           // GvProductList.Columns[1].HeaderText = "NAME";

        }

        private void AddNewProductButton_Click(object sender, EventArgs e)
        {
            var AddEditProduct = new AddEditProduct(this);
            AddEditProduct.MdiParent = this.MdiParent;
            AddEditProduct.Show();
            //MessageBox.Show("Your record has been updated");


        }

        private void EditProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                //get id if selected row 
                var id = (int)GvProductList.SelectedRows[0].Cells["id"].Value;

                //query the database
                var products = _db.TypesofProductsUpdateds.FirstOrDefault(s => s.id == id);

                //launch addEditproduct window with data

                var AddEditProduct = new AddEditProduct(products, this);
                AddEditProduct.MdiParent = this.MdiParent;
                AddEditProduct.Show();
                //MessageBox.Show("Your record has been updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }

            
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                //get id if selected row 
                var id = (int)GvProductList.SelectedRows[0].Cells["id"].Value;

                //query the database
                var products = _db.TypesofProductsUpdateds.FirstOrDefault(s => s.id == id);


                //delete the vehicle from the table

                _db.TypesofProductsUpdateds.Remove(products);
                _db.SaveChanges();
                MessageBox.Show("Your record has been deleted");


                GvProductList.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void buttonrefresh_click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            var products = _db.TypesofProductsUpdateds
                .Select(s => new

                {
                    Name = s.name,
                    Type = s.type,
                    Scent= s.scents,
                    Size = s.size,
                    s.id

                })
                .ToList();
            GvProductList.DataSource = products;
            GvProductList.Columns[3].HeaderText = "Size";
            GvProductList.Columns["id"].Visible = false;
        }
    }
}
