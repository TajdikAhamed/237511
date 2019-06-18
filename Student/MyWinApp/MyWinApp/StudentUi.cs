using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWinApp.Models;

namespace MyWinApp
{
    public partial class StudentUi : Form
    {
        private string connectionString;
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private string commandString;

        public StudentUi()
        {
            InitializeComponent();
            connectionString = @"Server=PC-301-24\SQLEXPRESS; Database=StudentDB; Integrated Security= True;";
            sqlConnection = new SqlConnection(connectionString);
        }

        private void StudentUi_Load(object sender, EventArgs e)
        {
            LoadDistrict();
        }

        private void LoadDistrict()
        {
            sqlConnection.Open();
            commandString = @"select * from Districts";
            sqlCommand = new SqlCommand(commandString,sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                districtComboBox.DataSource = dataTable;
            }
            


            sqlConnection.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.RollNo = rollNoTextBox.Text;
            student.Name = nameTextBox.Text;
            student.Age = Convert.ToInt32(ageTextBox.Text);
            student.Address = addressTextBox.Text;
            student.DistrictID = Convert.ToInt32(districtComboBox.SelectedValue);

            commandString = @"insert into students(RollNo,Name,[Age],Address, DistrictID ) values ('" + student.RollNo + "','" + student.Name + "'," + student.Age.ToString() + ",'" +
                            student.Address + "'," + student.DistrictID.ToString() + ")";
            Insert(commandString);
        }

        private void Insert(string commandString)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            int IsExecuted = sqlCommand.ExecuteNonQuery();

            if (IsExecuted > 0)
            {
                MessageBox.Show("Data Saved!");
            }
            else
            {
                MessageBox.Show("Data Saved Field!");
            }



            sqlConnection.Close();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {

            //commandString = @"select s.RollNo,s.Name,s.[Age],s.Address, d.Name as DistrictName from students s inner join Districts d on s.DistrictID = d.Id";
            commandString = @"select * from StudentsView"; 
            Display(commandString);
        }

        private void Display(string commandString)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                displayDataGridView.DataSource = dataTable;
            }



            sqlConnection.Close();
        }
    }
}
