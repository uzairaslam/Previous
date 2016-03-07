using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ORM
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MessageBox.Show(LoginClass.User_Id + "\n" + LoginClass.CanBarCodeExcpt + "\n" + LoginClass.CanPaperCodeExcpt + "\n" + LoginClass.CanRollNoExcpt + "\n" + LoginClass.CanSheetExcpt + "\n" + LoginClass.CanShiftExcpt);
        }

        private void DashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGenerateException_Click(object sender, EventArgs e)
        {
            //childForm cf = new childForm();
            //cf.TopLevel = false;
            //panlContainer.Controls.Add(cf);
            //cf.Show();
        }
    }
}
