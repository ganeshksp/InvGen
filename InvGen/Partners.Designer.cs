namespace InvGen
{
    partial class Partners
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BPid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSTINNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pinCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessPartnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceGeneratorDataSet = new InvGen.InvoiceGeneratorDataSet();
            this.businessPartnersTableAdapter = new InvGen.InvoiceGeneratorDataSetTableAdapters.BusinessPartnersTableAdapter();
            this.tableAdapterManager = new InvGen.InvoiceGeneratorDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBPName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGSTIN = new System.Windows.Forms.TextBox();
            this.CIN = new System.Windows.Forms.Label();
            this.txtCIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.txtAddress4 = new System.Windows.Forms.TextBox();
            this.txtAddress5 = new System.Windows.Forms.TextBox();
            this.txtPincode = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessPartnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceGeneratorDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BPid,
            this.bPNameDataGridViewTextBoxColumn,
            this.gSTINNODataGridViewTextBoxColumn,
            this.cINDataGridViewTextBoxColumn,
            this.address1DataGridViewTextBoxColumn,
            this.address2DataGridViewTextBoxColumn,
            this.address3DataGridViewTextBoxColumn,
            this.address4DataGridViewTextBoxColumn,
            this.address5DataGridViewTextBoxColumn,
            this.pinCodeDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.businessPartnersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(56, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(903, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // BPid
            // 
            this.BPid.DataPropertyName = "BPid";
            this.BPid.HeaderText = "ID";
            this.BPid.Name = "BPid";
            this.BPid.ReadOnly = true;
            this.BPid.Visible = false;
            // 
            // bPNameDataGridViewTextBoxColumn
            // 
            this.bPNameDataGridViewTextBoxColumn.DataPropertyName = "BPName";
            this.bPNameDataGridViewTextBoxColumn.HeaderText = "BPName";
            this.bPNameDataGridViewTextBoxColumn.Name = "bPNameDataGridViewTextBoxColumn";
            // 
            // gSTINNODataGridViewTextBoxColumn
            // 
            this.gSTINNODataGridViewTextBoxColumn.DataPropertyName = "GSTINNO";
            this.gSTINNODataGridViewTextBoxColumn.HeaderText = "GSTINNO";
            this.gSTINNODataGridViewTextBoxColumn.Name = "gSTINNODataGridViewTextBoxColumn";
            // 
            // cINDataGridViewTextBoxColumn
            // 
            this.cINDataGridViewTextBoxColumn.DataPropertyName = "CIN";
            this.cINDataGridViewTextBoxColumn.HeaderText = "CIN";
            this.cINDataGridViewTextBoxColumn.Name = "cINDataGridViewTextBoxColumn";
            // 
            // address1DataGridViewTextBoxColumn
            // 
            this.address1DataGridViewTextBoxColumn.DataPropertyName = "Address1";
            this.address1DataGridViewTextBoxColumn.HeaderText = "Address1";
            this.address1DataGridViewTextBoxColumn.Name = "address1DataGridViewTextBoxColumn";
            // 
            // address2DataGridViewTextBoxColumn
            // 
            this.address2DataGridViewTextBoxColumn.DataPropertyName = "Address2";
            this.address2DataGridViewTextBoxColumn.HeaderText = "Address2";
            this.address2DataGridViewTextBoxColumn.Name = "address2DataGridViewTextBoxColumn";
            // 
            // address3DataGridViewTextBoxColumn
            // 
            this.address3DataGridViewTextBoxColumn.DataPropertyName = "Address3";
            this.address3DataGridViewTextBoxColumn.HeaderText = "Address3";
            this.address3DataGridViewTextBoxColumn.Name = "address3DataGridViewTextBoxColumn";
            // 
            // address4DataGridViewTextBoxColumn
            // 
            this.address4DataGridViewTextBoxColumn.DataPropertyName = "Address4";
            this.address4DataGridViewTextBoxColumn.HeaderText = "Address4";
            this.address4DataGridViewTextBoxColumn.Name = "address4DataGridViewTextBoxColumn";
            // 
            // address5DataGridViewTextBoxColumn
            // 
            this.address5DataGridViewTextBoxColumn.DataPropertyName = "Address5";
            this.address5DataGridViewTextBoxColumn.HeaderText = "Address5";
            this.address5DataGridViewTextBoxColumn.Name = "address5DataGridViewTextBoxColumn";
            // 
            // pinCodeDataGridViewTextBoxColumn
            // 
            this.pinCodeDataGridViewTextBoxColumn.DataPropertyName = "PinCode";
            this.pinCodeDataGridViewTextBoxColumn.HeaderText = "PinCode";
            this.pinCodeDataGridViewTextBoxColumn.Name = "pinCodeDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // businessPartnersBindingSource
            // 
            this.businessPartnersBindingSource.DataMember = "BusinessPartners";
            this.businessPartnersBindingSource.DataSource = this.invoiceGeneratorDataSet;
            // 
            // invoiceGeneratorDataSet
            // 
            this.invoiceGeneratorDataSet.DataSetName = "InvoiceGeneratorDataSet";
            this.invoiceGeneratorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // businessPartnersTableAdapter
            // 
            this.businessPartnersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusinessPartnersTableAdapter = this.businessPartnersTableAdapter;
            this.tableAdapterManager.CompanyInfoTableAdapter = null;
            this.tableAdapterManager.GenerateInvoicePrintTableAdapter = null;
            this.tableAdapterManager.InvoiceDetailsTableAdapter = null;
            this.tableAdapterManager.ShippingItemTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = InvGen.InvoiceGeneratorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserInfoTableAdapter = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Partner Name";
            // 
            // txtBPName
            // 
            this.txtBPName.Location = new System.Drawing.Point(145, 10);
            this.txtBPName.Name = "txtBPName";
            this.txtBPName.Size = new System.Drawing.Size(158, 20);
            this.txtBPName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "GSTIN NO";
            // 
            // txtGSTIN
            // 
            this.txtGSTIN.Location = new System.Drawing.Point(145, 43);
            this.txtGSTIN.Name = "txtGSTIN";
            this.txtGSTIN.Size = new System.Drawing.Size(158, 20);
            this.txtGSTIN.TabIndex = 4;
            // 
            // CIN
            // 
            this.CIN.AutoSize = true;
            this.CIN.Location = new System.Drawing.Point(59, 76);
            this.CIN.Name = "CIN";
            this.CIN.Size = new System.Drawing.Size(25, 13);
            this.CIN.TabIndex = 5;
            this.CIN.Text = "CIN";
            // 
            // txtCIN
            // 
            this.txtCIN.Location = new System.Drawing.Point(145, 76);
            this.txtCIN.Name = "txtCIN";
            this.txtCIN.Size = new System.Drawing.Size(158, 20);
            this.txtCIN.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address 4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(651, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Address 5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(651, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "PIN Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(654, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "State";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(421, 10);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(165, 20);
            this.txtAddress1.TabIndex = 14;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(421, 42);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(165, 20);
            this.txtAddress2.TabIndex = 15;
            // 
            // txtAddress3
            // 
            this.txtAddress3.Location = new System.Drawing.Point(421, 76);
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(165, 20);
            this.txtAddress3.TabIndex = 16;
            // 
            // txtAddress4
            // 
            this.txtAddress4.Location = new System.Drawing.Point(725, 13);
            this.txtAddress4.Name = "txtAddress4";
            this.txtAddress4.Size = new System.Drawing.Size(170, 20);
            this.txtAddress4.TabIndex = 17;
            // 
            // txtAddress5
            // 
            this.txtAddress5.Location = new System.Drawing.Point(725, 42);
            this.txtAddress5.Name = "txtAddress5";
            this.txtAddress5.Size = new System.Drawing.Size(170, 20);
            this.txtAddress5.TabIndex = 18;
            // 
            // txtPincode
            // 
            this.txtPincode.Location = new System.Drawing.Point(725, 76);
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.Size = new System.Drawing.Size(170, 20);
            this.txtPincode.TabIndex = 19;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(728, 108);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(170, 20);
            this.txtState.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(504, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Partners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 409);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtPincode);
            this.Controls.Add(this.txtAddress5);
            this.Controls.Add(this.txtAddress4);
            this.Controls.Add(this.txtAddress3);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCIN);
            this.Controls.Add(this.CIN);
            this.Controls.Add(this.txtGSTIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBPName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Partners";
            this.Text = "Partners";
            this.Load += new System.EventHandler(this.Partners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessPartnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceGeneratorDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private InvoiceGeneratorDataSet invoiceGeneratorDataSet;
        private System.Windows.Forms.BindingSource businessPartnersBindingSource;
        private InvoiceGeneratorDataSetTableAdapters.BusinessPartnersTableAdapter businessPartnersTableAdapter;
        private InvoiceGeneratorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBPName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGSTIN;
        private System.Windows.Forms.Label CIN;
        private System.Windows.Forms.TextBox txtCIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.TextBox txtAddress4;
        private System.Windows.Forms.TextBox txtAddress5;
        private System.Windows.Forms.TextBox txtPincode;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn BPid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSTINNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pinCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
    }
}