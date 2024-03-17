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
    public partial class Form1 : Form
    {
        private readonly Sensational_ScentsEntities SensationalScentsEntities;
        public Form1()
        {
            InitializeComponent();
            SensationalScentsEntities = new Sensational_ScentsEntities();
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
                    var ScensationalScentRecord = new SensationalRecord();
                    ScensationalScentRecord.CustomerName = CustomerName;
                    ScensationalScentRecord.DateOrdered = OrderDate;
              //      ScensationalScentRecord.CustomerNumner = customerNumber;
                    ScensationalScentRecord.CustomerAddress = CustomerAddress;
                    ScensationalScentRecord.Cost = (decimal) cost;
                    ScensationalScentRecord.TypeofProductID = (int) ProductDropDown.SelectedValue;

                    SensationalScentsEntities.SensationalRecords.Add(ScensationalScentRecord);
                    SensationalScentsEntities.SaveChanges();

                    
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
            var products = SensationalScentsEntities.TypesofProductsUpdateds.ToList();
               ProductDropDown.DisplayMember = "Name";
            ProductDropDown.ValueMember = "id";
            ProductDropDown.DataSource = products;
        
        }
    }
}
