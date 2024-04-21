using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sensational_Scents_F
{
    public partial class Login : Form

    {
        private readonly Sensational_ScentsEntities _db;
        public Login()
        {
            InitializeComponent();

            _db = new Sensational_ScentsEntities();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();
                var username = usernameTextBox.Text.Trim();
                var password = passwordTextBox.Text;

                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder sBuilder = new StringBuilder();

                for (int i = 0; i <data.Length; i++) 
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                var hashed_password = sBuilder.ToString();

                var user = _db.users.FirstOrDefault(s => s.username == username && s.password == hashed_password && s.isActive==true);
                if (user == null) 
                {
                    MessageBox.Show("Invalid username or password");
                    
                }
                else
                {
                    //var role = user.user_roles.FirstOrDefault();
                    //var roleShortName = role.Role.shortname;
                    //var mainWindow = new MainWindow(this, roleShortName);
                    var mainWindow = new MainWindow(this, user);

                    mainWindow.Show();
                    Hide();

                }
            }
            catch (Exception ex) 
            {

                MessageBox.Show("Something went wrong! Please try again.");
            }
        }
    }
}
