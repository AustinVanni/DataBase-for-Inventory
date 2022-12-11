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
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Usuario\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        void DataShow()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CustomerTbl";
                
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                drvCustomers.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomerTbl values(" + txtCusId.Text + ",'" + txtCusName.Text + "','"+txtCusPhone.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Succesfully Added");
                Con.Close();
                DataShow();


            }
            catch
            {

            }
        }
      

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            DataShow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCusId.Text == "")
            {
                MessageBox.Show("Enter The Customer´s ID");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CustomerTbl set CustName='" + txtCusName.Text + "',CustPhone='" + txtCusPhone.Text + "' where CustId='" + txtCusId.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Succesfully Updated");

                Con.Close();
                DataShow();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtCusId.Text == "")
            {
                MessageBox.Show("Enter The Customer Id ");
            }
            else
            {
                Con.Open();
                string MyQuery = "delete from CustomerTbl where CustId='" + txtCusId.Text + "' ;";
                SqlCommand cmd = new SqlCommand(MyQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Succesfully Deleted");

                Con.Close();
                DataShow();


            }
        }

        private void drvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCusId.Text = drvCustomers.SelectedRows[0].Cells[0].Value.ToString();
            txtCusName.Text = drvCustomers.SelectedRows[0].Cells[1].Value.ToString();
            txtCusPhone.Text = drvCustomers.SelectedRows[0].Cells[2].Value.ToString();
            
        }
    }
}
