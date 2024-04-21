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
    public partial class ManageUsers : Form
    {
        private readonly Sensational_ScentsEntities _db;
        public ManageUsers()
        {
            InitializeComponent();
            _db = new Sensational_ScentsEntities();
        }

        private void buttonaddnewusers_Click(object sender, EventArgs e)
        {

        }

        private void resetpasswordbutton_Click(object sender, EventArgs e)
        {
            try
            {
                //get id if selected row 
                var id = (int)GvUserList.SelectedRows[0].Cells["id"].Value;

                //query the database
                var user = _db.users.FirstOrDefault(s => s.id == id);

                var new_password = "Password@123";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        private void buttondeactivateuser_Click(object sender, EventArgs e)
        {

        }
    }
}
