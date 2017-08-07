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
    public partial class Items : Form
    {
        int ID = 0;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["InvGenConString"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter adapt;  
        public Items()
        {
            InitializeComponent();
        }

        private void Items_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invoiceGeneratorDataSet.ShippingItem' table. You can move, or remove it, as needed.
            FillDropDown();
            DisplayData();

        }
        public string FillDropDownList(ComboBox cboDropDown, DataSet oDataset, string sRowfilterExpression, string sDataTextField, string sDataValueField, string sFieldName)
        {
            DataView ObjDataView = new DataView();
            try
            {
                //cboDropDown.Items.Clear();
                //Set given properties on dropdownlist
                cboDropDown.DisplayMember = sDataTextField;
                cboDropDown.ValueMember = sDataValueField;
                //Bind / Fill data..
                DataRow newRow = oDataset.Tables[0].NewRow();

                newRow[1] = "Please Select";
                newRow[0] = 0;

                oDataset.Tables[0].Rows.InsertAt(newRow, 0);

                ObjDataView = oDataset.Tables[0].DefaultView;
                cboDropDown.DataSource = ObjDataView;
                //Set any filter criteria on dataview 

                ObjDataView.RowFilter = sRowfilterExpression == "" ? "order by 1" : sRowfilterExpression;
            }
            catch (Exception e1)
            {
                //Return error string if exception occurred from here..
                return e1.Message.ToString();

            }
            return null;
        }


        private void FillDropDown()
        {
            SqlConnectionInfo db = new SqlConnectionInfo();
            FillDropDownList(ddlBPName, db.GetDataSet("select * from BusinessPartners where isactive=1"), "", "BPName", "Bpid", "BPName");
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select ItemId,ItemName,HSNCode,UnitPrice,UOM,b.BPid as BPID,BPName from ShippingItem s inner join BusinessPartners b on b.BPid=s.Bpid where s.IsActive=1 and b.IsActive=1", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["ItemId"].Visible = false;
            dataGridView1.Columns["BPID"].Visible = false;
            con.Close();
        }
        //add
        private void button1_Click(object sender, EventArgs e)
        {
            if (ddlBPName.SelectedValue != "0" && txtHSNCode.Text != "" && txtItemName.Text != "" && txtUnitPrice.Text != "" && txtUOM.Text != "")
            {
                cmd = new SqlCommand("insert into ShippingItem values(@itemname,@hsncode,@unitprice,1,@uom,@bpid)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@itemname", txtItemName.Text);
                cmd.Parameters.AddWithValue("@hsncode", txtHSNCode.Text);
                
                cmd.Parameters.AddWithValue("@unitprice", txtUnitPrice.Text);
                cmd.Parameters.AddWithValue("@uom", txtUOM.Text);
                cmd.Parameters.AddWithValue("@bpid", ddlBPName.SelectedValue);
                

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
            if (ddlBPName.SelectedValue.ToString() != "0" && txtHSNCode.Text != "" && txtItemName.Text != "" && txtUnitPrice.Text != "" && txtUOM.Text != "")
            {
                cmd = new SqlCommand("update ShippingItem set ItemName=@itemname,HSNCOde=@hsncode,UnitPrice=@unitprice,UOM=@uom,bpid=@bpid where itemid=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", txtItemName.Text);
                cmd.Parameters.AddWithValue("@hsncode", txtHSNCode.Text);
                
                cmd.Parameters.AddWithValue("@unitprice", txtUnitPrice.Text);
                cmd.Parameters.AddWithValue("@uom", txtUOM.Text);
                cmd.Parameters.AddWithValue("@bpid", ddlBPName.SelectedValue);


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

        private void ClearData()
        {
            ID = 0;
            txtItemName.Text = "";
            txtHSNCode.Text = "";
            txtUnitPrice.Text = "";
            txtUOM.Text = "";
            ddlBPName.SelectedValue = "0";
        }
        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("UPDATE ShippingItem SET IsActive=0 where itemid=@id", con);
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtItemName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtHSNCode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtUnitPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtUOM.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            ddlBPName.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[5].Value;
            
        }

    }
}
