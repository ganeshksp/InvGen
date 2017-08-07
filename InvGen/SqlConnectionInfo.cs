using System;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.IO;



namespace InvGen
{
    public class SqlConnectionInfo
    {
        String dbConnection;

        public SqlConnectionInfo()
        {
            dbConnection  = ConfigurationManager.ConnectionStrings["InvGenConString"].ConnectionString;
        }
        public void BulkUpload(DataTable dtQBA, string dt)
        {
            SqlTransaction trn = null; SqlBulkCopy bulkCopy;
            try
            {
                SqlConnection connection = new SqlConnection(dbConnection);
                connection.Open();
                using (trn = connection.BeginTransaction(IsolationLevel.Serializable))
                {
                    using (bulkCopy = new SqlBulkCopy(connection, SqlBulkCopyOptions.Default, trn))
                    {
                        bulkCopy.DestinationTableName = dt;
                        bulkCopy.WriteToServer(dtQBA);
                        bulkCopy.Close();
                        trn.Commit();
                    }
                }

                connection.Close();
            }
            catch (SqlException ex)
            {
                if (trn != null)
                    trn.Rollback();

                throw ex;
                //throw new PayfeeException(1100, "UploadStudentExcelFileData", ex.Message, varUsersession);
            }
        }
        public int GetMaxInvoiceNum()
        {
            try
            {
                SqlConnection connection = new SqlConnection(dbConnection);

                string selectText = "select isnull(max((InvoiceNumber)),1987) from InvoiceDetails";
                SqlCommand command = new SqlCommand(selectText, connection);

                connection.Open();
                var maxVal = command.ExecuteScalar();
                connection.Close();
                int x = 0;
                int.TryParse(maxVal.ToString(), out x);
                if (x == 0) return 0;
                else return x;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int GetInvoiceNumber()
        {

            try
            {
                SqlConnection connection = new SqlConnection(dbConnection);

                string selectText = "select isnull(max((InvoiceNumber)+1),1987) from InvoiceDetails";
                SqlCommand command = new SqlCommand(selectText, connection);

                connection.Open();
                var maxVal = command.ExecuteScalar();
                connection.Close();
                int x = 0;
                int.TryParse(maxVal.ToString(), out x);
                if (x == 0) return 0;
                else return x;
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
        public DataSet GetDataSet(string sql)
        {
            DataSet dt = new DataSet();
            try
            {
                SqlConnection cnn = new SqlConnection(dbConnection);
                cnn.Open();
                SqlCommand mycommand = new SqlCommand(sql, cnn);
                mycommand.CommandType = CommandType.Text;
                SqlDataAdapter objDataAdapter = new SqlDataAdapter(mycommand);
                objDataAdapter.Fill(dt);
                cnn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;

            }
            return dt;
        }
        public string ValidateUser(string uname, string password)
        {
            string validator = "";

            try
            {
                SqlConnection connection = new SqlConnection(dbConnection);

                string selectText = "select [Role] from UserInfo where username='"+uname+ "' and password='" + password +"'";
                SqlCommand command = new SqlCommand(selectText, connection);

                connection.Open();
                var role = command.ExecuteScalar();
                connection.Close();
                if (role != null)
                    validator = role.ToString();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return validator;
        }
        public void SaveInvoice(string p)
        {
            
            try
            {
                SqlConnection cnn = new SqlConnection(dbConnection);
                cnn.Open();
                SqlCommand mycommand = new SqlCommand(p, cnn);
                mycommand.CommandType = CommandType.Text;
                int resset = mycommand.ExecuteNonQuery();
                cnn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;

            }
            
        }
       
    }
}
