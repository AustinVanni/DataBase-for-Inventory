using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Management
{
    public partial class FrmManageUsers : Form
    {
        public FrmManageUsers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Usuario\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try 
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl values('"+TxtUserName.Text+"','"+txtFullName.Text+"','"+txtPassword.Text+"','"+txtTelephone.Text+"')",Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Succesfully Added");
                Con.Close();
                DataShow();


            }
            catch
            {
                    
            }
        }


        void DataShow()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from UserTbl";
                Con.Close();
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                drvUsers.DataSource = ds.Tables[0];
            }
            catch
            {

            }
        }

        private void FrmManageUsers_Load(object sender, EventArgs e)
        {
            DataShow();

        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtTelephone.Text == "")
            {
                MessageBox.Show("Enter The Users Phone Number");
            }
            else
            {
                Con.Open();
                string MyQuery = "delete from UserTbl where UPhone='" + txtTelephone.Text + "'";
                SqlCommand cmd = new SqlCommand(MyQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Succesfully Deleted");

                Con.Close();
                DataShow();


            }
        }

        private void drvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtUserName.Text = drvUsers.SelectedRows[0].Cells[0].Value.ToString();
            txtFullName.Text = drvUsers.SelectedRows[0].Cells[1].Value.ToString();
            txtPassword.Text = drvUsers.SelectedRows[0].Cells[2].Value.ToString();
            txtTelephone.Text = drvUsers.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtTelephone.Text == "")
            {
                MessageBox.Show("Enter The Users Phone Number");
            }
            else
            {
                Con.Open();
                 SqlCommand cmd = new SqlCommand("update UserTbl set Uname='"+TxtUserName.Text+"',Ufullname='"+ txtFullName.Text+"',Upassword='"+txtPassword.Text+"' where UPhone='"+txtTelephone.Text+"'",Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Succesfully Updated");

                Con.Close();
                DataShow();


            }
        }
    }
}
