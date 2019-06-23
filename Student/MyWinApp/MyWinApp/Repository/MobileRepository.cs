using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWinApp.Models;

namespace MyWinApp.Repository
{
    public class MobileRepository
    {

        private string connectionString = @"Server=PC-301-24\SQLEXPRESS; Database=MobileManagementDB; Integrated Security= True;";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private string commandString;
        //sqlConnection = new SqlConnection(connectionString);

        public bool Insert(Mobile mobile)
        {
            bool IsInsert = false;
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            commandString = @"INSERT INTO [dbo].[Mobiles]
           ([name]
           ,[price]
           ,[IMEI])
     VALUES
           ('"+mobile.Name+"',"+mobile.Price+",'"+mobile.IMEI+"')";

            sqlCommand = new SqlCommand(commandString, sqlConnection);

            int isExecuted = sqlCommand.ExecuteNonQuery();
            if (isExecuted > 0)
            {
                IsInsert = true;
            }

            return IsInsert;
        }


        public DataTable SearchByPrice(double lowRange, double highRange)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            commandString = @"select * from mobiles where price between "+lowRange+" and "+highRange+" ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            if (dataTable.Rows.Count > 0)
            {

                return dataTable;
            }

            return dataTable;
        }

        public Mobile SearchByIMEI(string IMEI)
        {
            Mobile mobile = new Mobile();
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            commandString = @"select * from mobiles where IMEI = '" + IMEI + "' ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            if (dataTable.Rows.Count > 0)
            {

               mobile.id = Convert.ToInt32(dataTable.Rows[0].ItemArray[0]);
               mobile.Name =  dataTable.Rows[0].ItemArray[1].ToString();
               mobile.Price = Convert.ToDouble( dataTable.Rows[0].ItemArray[2]);
               mobile.IMEI =  dataTable.Rows[0].ItemArray[3].ToString();

                return mobile;
            }

            return mobile;
        }


        public DataTable LoadDistrict()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            commandString = @"select * from Districts";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            DataRow row = dataTable.NewRow();
            row[0] = 0;
            row[1] = "--select--";
            dataTable.Rows.InsertAt(row, 0);
            sqlConnection.Close();
            if (dataTable.Rows.Count > 0)
            {
                //districtComboBox.Items.Insert(0, "SELECT,0");
                //districtComboBox.SelectedIndex = 0;
                //districtComboBox.DataSource = dataTable;

                //districtComboBox.SelectedItem = null;
                //districtComboBox.SelectedText = "--select--";
                return dataTable;
            }

            return dataTable;
        }

    }
}
