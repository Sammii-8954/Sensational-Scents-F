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
    public partial class AddEditProduct : Form

    {
        //this condition will determine whether to add or edit the form depending on the function selected
        private bool isthisinEditMode;
        private ManageProductListing _manageProductListing;
        private readonly Sensational_ScentsEntities _db;

        //load the form when add new product is selected
        public AddEditProduct(ManageProductListing manageProductListing = null)
        {
            InitializeComponent();
            labelTitle.Text = "Add new Product";
            isthisinEditMode = false;
            _manageProductListing = manageProductListing;
            _db = new Sensational_ScentsEntities();

        }

        //overloading constructor when the edit product button is selected
        public AddEditProduct(TypesofProductsUpdated productstoEdit, ManageProductListing manageProductListing = null)
        {
            InitializeComponent();
            labelTitle.Text = "Edit product";
            isthisinEditMode=true;
            _manageProductListing = manageProductListing;

            _db = new Sensational_ScentsEntities();

            PopulateFields(productstoEdit);
            
        }

        private void PopulateFields(TypesofProductsUpdated products)
        {
            labelid.Text = products.id.ToString();
            textBoxName.Text = products.name;
            textBoxScent.Text = products.scents;
            textBoxSize.Text = products.size;
            textBoxtproductType.Text = products.type;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (isthisinEditMode)
            {
                //edit code here
                var id = int.Parse(labelid.Text);
                var products = _db.TypesofProductsUpdateds.FirstOrDefault(s => s.id == id);
                products.type = textBoxtproductType.Text;
                products.scents = textBoxScent.Text;
                products.size = textBoxSize.Text;
                products.name = textBoxName.Text;

                _db.SaveChanges();

            }
            else
            {
                //add code here

                var newproducts = new TypesofProductsUpdated
                {
                    type = textBoxtproductType.Text,
                    scents = textBoxScent.Text,
                    size = textBoxSize.Text,
                    name = textBoxName.Text,

                };

                _db.TypesofProductsUpdateds.Add(newproducts);
                _db.SaveChanges();
                _manageProductListing.PopulateGrid();
                MessageBox.Show("Operation Completed. Kindly refresh to see changes");
                Close();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
