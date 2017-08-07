using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace InvGen
{
    public partial class Partners : Form
    {
        int ID = 0;
        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["InvGenConString"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter adapt;  
        public Partners()
        {
            InitializeComponent();
        }

        private void Partners_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invoiceGeneratorDataSet.BusinessPartners' table. You can move, or remove it, as needed.
            DisplayData();

        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from BusinessPartners where IsActive=1", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtBPName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtGSTIN.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCIN.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAddress1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtAddress2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtAddress3.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtAddress4.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtAddress5.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtPincode.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtState.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();

        }
        //add
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBPName.Text != "" && txtGSTIN.Text != "" && txtCIN.Text != "" && txtAddress1.Text != "" && txtAddress2.Text != "" && txtAddress3.Text != "" && txtAddress4.Text != "" && txtAddress5.Text != "" && txtPincode.Text != "" && txtState.Text != "")
            {
                cmd = new SqlCommand("insert into BusinessPartners values(@name,@gstin,@cin,@address1,@address2,@address3,@address4,@address5,@pincode,@state,1)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", txtBPName.Text);
                cmd.Parameters.AddWithValue("@gstin", txtGSTIN.Text);
                cmd.Parameters.AddWithValue("@cin", txtCIN.Text);
                cmd.Parameters.AddWithValue("@address1", txtAddress1.Text);
                cmd.Parameters.AddWithValue("@address2", txtAddress2.Text);
                cmd.Parameters.AddWithValue("@address3", txtAddress3.Text);
                cmd.Parameters.AddWithValue("@address4", txtAddress4.Text);
                cmd.Parameters.AddWithValue("@address5", txtAddress5.Text);
                cmd.Parameters.AddWithValue("@pincode", txtPincode.Text);
                cmd.Parameters.AddWithValue("@state", txtState.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }  
        }
        //update
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtBPName.Text != "" && txtGSTIN.Text != "" && txtCIN.Text != "" && txtAddress1.Text != "" && txtAddress2.Text != "" && txtAddress3.Text != "" && txtAddress4.Text != "" && txtAddress5.Text != "" && txtPincode.Text != "" && txtState.Text != "")
            {
                cmd = new SqlCommand("update BusinessPartners set BPName=@name,GSTINNO=@gstin,CIN=@cin,Address1=@address1,Address2=@address2,Address3=@address3,Address4=@address4,Address5=@address5,Pincode=@pincode,State=@state where BPid=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", txtBPName.Text);
                cmd.Parameters.AddWithValue("@gstin", txtGSTIN.Text);
                cmd.Parameters.AddWithValue("@cin", txtCIN.Text);
                cmd.Parameters.AddWithValue("@address1", txtAddress1.Text);
                cmd.Parameters.AddWithValue("@address2", txtAddress2.Text);
                cmd.Parameters.AddWithValue("@address3", txtAddress3.Text);
                cmd.Parameters.AddWithValue("@address4", txtAddress4.Text);
                cmd.Parameters.AddWithValue("@address5", txtAddress5.Text);
                cmd.Parameters.AddWithValue("@pincode", txtPincode.Text);
                cmd.Parameters.AddWithValue("@state", txtState.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }  
        }
        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("UPDATE BusinessPartners SET IsActive=0 where BPid=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }  
        }

        private void ClearData()
        {
            ID = 0;
            txtBPName.Text = "";
            txtGSTIN.Text = "";
            txtCIN.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtAddress3.Text = "";
            txtAddress4.Text = "";
            txtAddress5.Text = "";
            txtPincode.Text = "";
            txtState.Text = "";
        }
        

        
        
    }
}
