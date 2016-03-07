using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace ORM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtUsrName.Clear();
                txtPassword.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginClass LC = new LoginClass();
                bool LoginResult = LC.getUserId(txtUsrName.Text, txtPassword.Text);
                if (LoginResult)
                {
                    DashBoard dash = new DashBoard();
                    dash.Show();
                    this.Hide();
                    
                }
                else
                {
                    label4.Text = "Wrong User Name or Password";
                    timer1.Start();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                label4.Text = string.Empty;
                
                timer1.Stop();
            }
            catch (Exception ex)
            {

                
            }
        }
    }
}
