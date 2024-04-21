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
    public partial class ManageProductRecords : Form
    {
        private readonly Sensational_ScentsEntities _db;
        public ManageProductRecords()
        {
            InitializeComponent();
            _db = new Sensational_ScentsEntities();
        }

        private void EditRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                //get id of selected row 
                var id = (int)GvRecordList.SelectedRows[0].Cells["id"].Value;

                //query the database
                var record = _db.SensationalRecords.FirstOrDefault(s => s.id == id);

                //launch addEditproduct window with data
                var addEditSensationalRecord = new AddEditSensationalRecords(record);
                addEditSensationalRecord.MdiParent = this.MdiParent;
                addEditSensationalRecord.Show();



            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error : { ex.Message}");
            }

        }

        private void AddNewRecordButton_Click(object sender, EventArgs e)
        {
            var SensationalRecord = new AddEditSensationalRecords
            {
                MdiParent = this.MdiParent
            };
            SensationalRecord.Show();

            
            //MessageBox.Show("Your record has been updated");
        }

        private void buttonrefresh_archive_Click(object sender, EventArgs e)
        {

        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                //get id if selected row 
                var id = (int)GvRecordList.SelectedRows[0].Cells["id"].Value;

                //query the database
                var records = _db.SensationalRecords.FirstOrDefault(s => s.id == id);


                //delete the vehicle from the table

                _db.SensationalRecords.Remove(records);
                _db.SaveChanges();
                MessageBox.Show("Your record has been updated");


                PopulateGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }



        }

        private void ManageProductRecords_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void PopulateGrid()
        {
            var records = _db.SensationalRecords.Select(s => new {
            Customer = s.CustomerName,
            CustomerNumber = s.CustomerNumner,
            DateofOrder = s.DateOrdered,
            Id= s.id,
            DeliveryAddress = s.CustomerAddress,
            cost=s.Cost,
            ProductType = s.TypesofProductsUpdated.type + "" + s.TypesofProductsUpdated.name
            
            }).ToList();

            GvRecordList.DataSource = records;
            GvRecordList.Columns["DateofOrder"].HeaderText = "Your Order was Placed on :";
            GvRecordList.Columns["id"].Visible = false;
        }
    }
}
