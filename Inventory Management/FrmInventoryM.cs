using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class FrmInventoryM : Form
    {
        public FrmInventoryM()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void showpasschk_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasschk.Checked == false)
            {
                txtpassword.UseSystemPasswordChar = true;

            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UserNameTxt.Text = "";
            txtpassword.Text = "";

        }
    }
}
