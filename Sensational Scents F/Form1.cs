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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string CustomerName = CustomerNameBox.Text;
            string OrderDate = DateofOrder.Value.ToString();
            var product = ProductDropDown.SelectedItem.ToString();
            string CustomerAddress = DeliveryAddressBox.Text;
            string customerNumber = CustomerNoBox.Text;
            double cost = Convert.ToDouble(CostBox.Text);
            var isValid = true;

            if(string.IsNullOrWhiteSpace(CustomerName) || string.IsNullOrWhiteSpace(product) || string.IsNullOrWhiteSpace(CustomerAddress))
            {
                isValid = false;
                MessageBox.Show("Please enter missing data.");

            }
            // if (isValid == True)
            if(isValid)
            {
                MessageBox.Show($"Customer Name: {CustomerName}\n\r" +
                $"Date of Order: {OrderDate}\n\r" +
                $"Delievery Address: {CustomerAddress}\n\r" +
                $"Cost: {cost}\n\r" +
                $"Customer Number: {customerNumber}\n\r" +
                $"Product: {product}\n\r" +
                $"Thank you for your purchase! Your order will be shipped within 3-5 business days");

            }

            
        }
    }
}
