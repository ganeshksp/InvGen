using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace InvGen
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
            FillAllValues();
        }

        private void FillAllValues()
        {
            PopulateDropdowns(); 
            GenerateLabelValues();
            lblInvoiceNo.Text= GetInvoiceNumber();
            lblInvoiceDate.Text = DateTime.Now.ToShortDateString();
            txtQuantity.Text = "0";
        }


        private string GetInvoiceNumber()
        {
            SqlConnectionInfo db = new SqlConnectionInfo();
            return db.GetInvoiceNumber().ToString();
        }

        private void GenerateLabelValues()
        {
            SqlConnectionInfo db = new SqlConnectionInfo();
            DataSet firstSet = db.GetDataSet("select * from CompanyInfo");
            lblCompanyName.Text = firstSet.Tables[0].Rows[0]["CompanyName"].ToString();
            lblGSTINNO.Text = firstSet.Tables[0].Rows[0]["GSTINNO"].ToString();
            lblCIN.Text = firstSet.Tables[0].Rows[0]["CIN"].ToString();
            lblAddress.Text = firstSet.Tables[0].Rows[0]["Address1"].ToString() + ", " + firstSet.Tables[0].Rows[0]["Address2"].ToString() + ", " + firstSet.Tables[0].Rows[0]["Address3"].ToString()
                + ", " + firstSet.Tables[0].Rows[0]["Address4"].ToString() + ", " + firstSet.Tables[0].Rows[0]["Address5"].ToString();
        }

        private void PopulateDropdowns()
        {
            SqlConnectionInfo db = new SqlConnectionInfo();
            FillDropDownList(ddlItemList, db.GetDataSet("select * from ShippingItem where itemid=0 and isactive=1"), "", "ItemName", "ItemId", "ItemName");
            FillDropDownList(ddlBPName, db.GetDataSet("select * from BusinessPartners where isactive=1"), "", "BPName", "BPid", "BPName");
                
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

                oDataset.Tables[0].Rows.InsertAt(newRow,0);

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

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

            CalculateTotals();

        }

        private void ddlItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlItemList.SelectedValue.ToString() == "0")
            {
                lblUnitPrice.Text = "0";
                lblHSNCode.Text = "";
            }
            else
            {
                SqlConnectionInfo db = new SqlConnectionInfo();
                DataSet firstSet = db.GetDataSet("select * from ShippingItem where ItemId=" + ddlItemList.SelectedValue.ToString());
                lblUnitPrice.Text = firstSet.Tables[0].Rows[0]["UnitPrice"].ToString();
                lblHSNCode.Text = firstSet.Tables[0].Rows[0]["HSNCode"].ToString();
            }
            CalculateTotals();
        }

        private void CalculateTotals()
        {
            double num = 0; double btp = 0; double atp = 0; double taxamt = 0;

            if (ddlItemList.SelectedValue.ToString() != "0")
            {
                if (txtQuantity.Text != null)
                {
                    bool q = double.TryParse(txtQuantity.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out num);
                    if (q)
                    {
                        btp = double.Parse(lblUnitPrice.Text.ToString()) * num;
                        taxamt = btp * 0.05;
                        atp = btp + taxamt;
                    }
                }
            }

            lblTotalAmount.Text = atp.ToString();
            lblTotalTax.Text = taxamt.ToString();
            lblTaxableValue.Text = btp.ToString(); 
        }

        private void ddlBPName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlBPName.SelectedValue.ToString() == "0")
            {
                lblBPAddress1.Text = "";
                lblBPAddress2.Text = "";
                lblBPAddress3.Text = "";
                lblBPAddress4.Text = "";
                lblBPState2.Text = lblBPState.Text = "";
                lblBPGSTINNO.Text = lblConsigneeGSTIN.Text = "";
                lblStateCode.Text = lblConsigneeStateCode.Text = "";
                lblBPName.Text = "";
                lblConsigneeAddress.Text="";
                ddlItemList.SelectedValue = "0"; 
            }
            else
            {
                SqlConnectionInfo db = new SqlConnectionInfo();
                DataSet firstSet = db.GetDataSet("select * from BusinessPartners where BPid=" + ddlBPName.SelectedValue.ToString());
                lblBPName.Text = firstSet.Tables[0].Rows[0]["BPName"].ToString();
                lblBPAddress1.Text = firstSet.Tables[0].Rows[0]["Address1"].ToString();
                lblBPAddress2.Text = firstSet.Tables[0].Rows[0]["Address2"].ToString();
                lblBPAddress3.Text = firstSet.Tables[0].Rows[0]["Address3"].ToString();
                lblBPAddress4.Text = firstSet.Tables[0].Rows[0]["Address4"].ToString();
                lblConsigneeAddress.Text = lblBPState2.Text = lblBPState.Text = firstSet.Tables[0].Rows[0]["State"].ToString();
                lblBPGSTINNO.Text = lblConsigneeGSTIN.Text = firstSet.Tables[0].Rows[0]["GSTINNO"].ToString();
                lblStateCode.Text = lblConsigneeStateCode.Text = "29";

                DataSet secSet = db.GetDataSet("select * from ShippingItem where BPid=" + ddlBPName.SelectedValue.ToString());
                FillDropDownList(ddlItemList, secSet, "", "ItemName", "ItemId", "ItemName");
            }
        }

        private void btnInvoiceGen_Click(object sender, EventArgs e)
        {
            SaveInvoiceDetails();
            GenerateReport();
        }

        private void GenerateReport()
        {
            PrintInvoice pi = new PrintInvoice(); pi.StartPosition=FormStartPosition.CenterParent ;
            pi.ShowDialog();
        }

        private void SaveInvoiceDetails()
        {
            SqlConnectionInfo db = new SqlConnectionInfo();
            db.SaveInvoice("insert into InvoiceDetails values('"+lblInvoiceNo.Text.ToString()+"','"+ Convert.ToDateTime(lblInvoiceDate.Text.ToString())+ "','"+ txtVehicleNum.Text.ToString()+"',"+ddlBPName.SelectedValue.ToString()+","+ddlItemList.SelectedValue.ToString()+","+txtQuantity.Text.ToString()+","+lblTaxableValue.Text.ToString()+","+lblTotalAmount.Text.ToString()  +")");
        }

    }
}
