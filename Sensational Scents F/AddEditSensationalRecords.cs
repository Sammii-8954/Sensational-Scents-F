using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sensational_Scents_F
{
    public partial class AddEditSensationalRecords : Form
    {
        private bool isthisinEditMode;
        private readonly Sensational_ScentsEntities _db;
        public AddEditSensationalRecords()
        {
            InitializeComponent();
            labelTitle.Text = "Add new Customer Order";

            isthisinEditMode = false;
            _db = new Sensational_ScentsEntities();
            
        }
        public AddEditSensationalRecords(SensationalRecord recordtoEdit)
        {
            InitializeComponent();
            labelTitle.Text = "Edit Customer Order";



            if(recordtoEdit == null) 
            {
                MessageBox.Show("Please ensure you selected a valid record to edit");
                Close();
            }
            else
            {
                isthisinEditMode = true;
                _db = new Sensational_ScentsEntities();
                PopulateFields(recordtoEdit);
            }
            
        }

        private void PopulateFields(SensationalRecord recordtoEdit)
        {
            CustomerNameBox.Text = recordtoEdit.CustomerName;
            //DateofOrder.Value = recordtoEdit.DateOrdered; value in the db is varchar which is causing a prblem
            CostBox.Text = recordtoEdit.Cost.ToString();
            DeliveryAddressBox.Text = recordtoEdit.CustomerAddress;
            CustomerNoBox.Text = recordtoEdit.CustomerNumner.ToString();
            labelid.Text = recordtoEdit.id.ToString();// invisible label on the AddEDITSensationalRecordForm
           //ProductDropDown.Text;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            try
            {
                string CustomerName = CustomerNameBox.Text;
                string OrderDate = DateofOrder.Value.ToString();
                double cost = Convert.ToDouble(CostBox.Text);
                
                string CustomerAddress = DeliveryAddressBox.Text;
                string customerNumber = CustomerNoBox.Text;
                var product = ProductDropDown.Text;
                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(CustomerName) || string.IsNullOrWhiteSpace(product) || string.IsNullOrWhiteSpace(CustomerAddress))
                {
                    isValid = false;
                    errorMessage += "Error! Pleae enter missing data.\n\r";

                }
                // if (isValid == True)
                if (isValid)
                {
                    if (isthisinEditMode)
                    {
                        var id = int.Parse(labelid.Text);
                        var ScensationalScentRecord = _db.SensationalRecords.FirstOrDefault (s=> s.id == id);//wish i could explain this
                     
                        ScensationalScentRecord.CustomerName = CustomerName;
                        ScensationalScentRecord.DateOrdered = OrderDate;
                        //ScensationalScentRecord.CustomerNumner = customerNumber;
                        ScensationalScentRecord.CustomerAddress = CustomerAddress;
                        ScensationalScentRecord.Cost = (decimal)cost;
                        ScensationalScentRecord.TypeofProductID = (int)ProductDropDown.SelectedValue;
                        _db.SaveChanges();

                        MessageBox.Show($"Customer Name: {CustomerName}\n\r" +
                        $"Date of Order: {OrderDate}\n\r" +
                        $"Delievery Address: {CustomerAddress}\n\r" +
                        $"Cost: {cost}\n\r" +
                        $"Customer Number: {customerNumber}\n\r" +
                        $"Product: {product}\n\r" +
                        $"Thank you for your purchase! Your order will be shipped within 3-5 business days");

                    }
                    else
                    {
                        var ScensationalScentRecord = new SensationalRecord();
                        ScensationalScentRecord.CustomerName = CustomerName;
                        ScensationalScentRecord.DateOrdered = OrderDate;
                        //      ScensationalScentRecord.CustomerNumner = customerNumber;
                        ScensationalScentRecord.CustomerAddress = CustomerAddress;
                        ScensationalScentRecord.Cost = (decimal)cost;
                        ScensationalScentRecord.TypeofProductID = (int)ProductDropDown.SelectedValue;

                        _db.SensationalRecords.Add(ScensationalScentRecord);
                        _db.SaveChanges();


                        MessageBox.Show($"Customer Name: {CustomerName}\n\r" +
                        $"Date of Order: {OrderDate}\n\r" +
                        $"Delievery Address: {CustomerAddress}\n\r" +
                        $"Cost: {cost}\n\r" +
                        $"Customer Number: {customerNumber}\n\r" +
                        $"Product: {product}\n\r" +
                        $"Thank you for your purchase! Your order will be shipped within 3-5 business days");

                    }
                    Close();
                }

                else
                {

                    MessageBox.Show(errorMessage);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
                //throw;
            }
           

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // var products = SensationalScentsEntities.TypesofProductsUpdateds.ToList();
            var products = _db.TypesofProductsUpdateds.Select(s => new { ID = s.id, Name = s.name }).ToList();
            
            ProductDropDown.DisplayMember = "Name";
            ProductDropDown.ValueMember = "id";
            ProductDropDown.DataSource = products;
        
        }

    }
}
