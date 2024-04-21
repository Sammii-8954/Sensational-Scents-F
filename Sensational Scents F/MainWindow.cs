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
    public partial class MainWindow : Form
    {
        private Login _login;
        public string _RoleName;
        public User _user;
        public MainWindow()
        {
            InitializeComponent();
            

        }

        public MainWindow (Login login, User user)
        {
            InitializeComponent();
            _login = login;
            //_RoleName = roleShortName;
            _login = login;
            _user = user;
            _RoleName = user.user_roles.FirstOrDefault().Role.shortname;
        }

        private void addCustomerRecodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SensationalScentRecords = new AddEditSensationalRecords();
            SensationalScentRecords.ShowDialog();
            SensationalScentRecords.MdiParent = this;
            //SensationalScentRecords.Show();



        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.Cast<Form>();
            var isOpen = openForms.Any(s => s.Name == "ManageProductListing");
            if (!isOpen)
                
            {
                var ProdutList = new ManageProductListing();
                ProdutList.MdiParent = this;
                ProdutList.Show();
            }
         
        }

        private void viewArchivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageProductrecords = new ManageProductRecords();
            manageProductrecords.MdiParent = this;
            manageProductrecords.Show();
            
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!Utils.FormIsOpen("ManageUsers"))

           // {
                var manageUsers = new ManageUsers();
                manageUsers.MdiParent = this;
                manageUsers.Show();
           // }
            

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if(_RoleName!= "admin") 
            {
                manageUsersToolStripMenuItem.Visible = false;
            }
        }
    }
}
