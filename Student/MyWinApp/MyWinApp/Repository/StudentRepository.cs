using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinApp.Repository
{
    public class StudentRepository
    {
        private string connectionString = @"Server=PC-301-24\SQLEXPRESS; Database=StudentDB; Integrated Security= True;";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private string commandString;
        //sqlConnection = new SqlConnection(connectionString);

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
