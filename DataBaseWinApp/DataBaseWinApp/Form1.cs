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

namespace DataBaseWinApp
{
    public partial class Form1 : Form
    {

        string connectionString = @"Server=PC-301-24\SQLEXPRESS; Database=StudentDB; Integrated Security= True;";

        public class Department {
            public string Name { get; set; }
            public string Code { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            Department department = new Department();

            department.Name = deptTextBox.Text;
            department.Code = codeTextBox.Text;

            Insert(department);
        }

        public void Insert(Department department)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand();
                string commandString = @"Insert Into Departments (Name, Code) Values('" + department.Name + "','" + department.Code + "')";
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();

                int isInsert = sqlCommand.ExecuteNonQuery();

                if (isInsert > 0)
                {
                    MessageBox.Show("Data Insert Succesfully");
                }
                else
                {
                    MessageBox.Show("Data Insert Failed");
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand();
                string commandString = @"Select ID, Name, COde from Departments";
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(sqlDataReader);
                    displayDataGridView.DataSource = dataTable;
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
