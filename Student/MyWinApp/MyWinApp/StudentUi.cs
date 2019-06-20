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
using MyWinApp.BLL;
using MyWinApp.Models;

namespace MyWinApp
{
    public partial class StudentUi : Form
    {
        StudentManager _studentManager = new StudentManager();
        //private string connectionString;
        //private SqlConnection sqlConnection;
        //private SqlCommand sqlCommand;
        //private string commandString;

        public StudentUi()
        {
            InitializeComponent();
            //connectionString = @"Server=PC-301-24\SQLEXPRESS; Database=StudentDB; Integrated Security= True;";
            //sqlConnection = new SqlConnection(connectionString);
        }

        private void StudentUi_Load(object sender, EventArgs e)
        {
            districtComboBox.DataSource = _studentManager.LoadDistrict();
        }

        //private void LoadDistrict()
        //{
        //    sqlConnection.Open();
        //    commandString = @"select * from Districts";
        //    sqlCommand = new SqlCommand(commandString,sqlConnection);

        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            
        //    DataTable dataTable = new DataTable();
        //    sqlDataAdapter.Fill(dataTable);

        //    DataRow row = dataTable.NewRow();
        //    row[0] = 0;
        //    row[1] = "--select--";
        //    dataTable.Rows.InsertAt(row, 0);

        //    if (dataTable.Rows.Count > 0)
        //    {
        //        //districtComboBox.Items.Insert(0, "SELECT,0");
        //        //districtComboBox.SelectedIndex = 0;
        //        districtComboBox.DataSource = dataTable;

        //        //districtComboBox.SelectedItem = null;
        //        //districtComboBox.SelectedText = "--select--";
        //    }
            


        //    sqlConnection.Close();
        //}

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Student student = new Student();
            //student.Id = Convert.ToInt32(idTextBox.Text);
            //student.RollNo = rollNoTextBox.Text;
            //student.Name = nameTextBox.Text;
            //student.Age = Convert.ToInt32(ageTextBox.Text);
            //student.Address = addressTextBox.Text;
            //student.DistrictID = Convert.ToInt32(districtComboBox.SelectedValue);

            //if (student.Id.ToString().Equals("0"))
            //{
            //    commandString = @"insert into students(RollNo,Name,[Age],Address, DistrictID ) values ('" +
            //                    student.RollNo + "','" + student.Name + "'," + student.Age.ToString() + ",'" +
            //                    student.Address + "'," + student.DistrictID.ToString() + ")";
            //    Insert(commandString);
            //}
            //else if (student.Id>0)
            //{
            //    commandString = @"update students set RollNo = '" +
            //                    student.RollNo + "',Name = '" + student.Name + "',[Age] = " + student.Age.ToString() + ",Address = '" + student.Address + "', DistrictID = " + student.DistrictID.ToString() + " where id = " + student.Id.ToString();
            //    Insert(commandString);
            //}
        }

        private void Insert(string commandString)
        {
            //sqlConnection.Open();
            //sqlCommand = new SqlCommand(commandString, sqlConnection);
            //int IsExecuted = sqlCommand.ExecuteNonQuery();

            //if (IsExecuted > 0)
            //{
            //    MessageBox.Show("Data Saved!");
            //}
            //else
            //{
            //    MessageBox.Show("Data Saved Field!");
            //}



            //sqlConnection.Close();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {

            ////commandString = @"select s.RollNo,s.Name,s.[Age],s.Address, d.Name as DistrictName from students s inner join Districts d on s.DistrictID = d.Id";
            //commandString = @"select * from StudentsView"; 
            //Display(commandString);
        }

        private void Display(string commandString)
        {
            //sqlConnection.Open();
            //sqlCommand = new SqlCommand(commandString, sqlConnection);

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            //DataTable dataTable = new DataTable();
            //sqlDataAdapter.Fill(dataTable);

            //if (dataTable.Rows.Count > 0)
            //{

            //    displayDataGridView.DataSource = dataTable;

            //    for (int i = 0; i < displayDataGridView.Rows.Count - 1; i++)
            //    {
            //        displayDataGridView.Rows[i].Cells[1].Value = (i + 1).ToString();
            //    }
            //}



            //sqlConnection.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            
            //var x = displayDataGridView.SelectedCells;
            //string id = displayDataGridView.Rows[x[0].RowIndex].Cells[0].Value.ToString();

            //commandString = @"select * from StudentsView where ID = '" + id + "'";
            //GetStudentByID(commandString);
            
        }

        private void displayDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetStudentByID(string commandString)
        {
            //Student s = new Student();
            //sqlConnection.Open();
            //sqlCommand = new SqlCommand(commandString, sqlConnection);

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            //DataTable dataTable = new DataTable();
            //sqlDataAdapter.Fill(dataTable);
           

            
            //if (dataTable.Rows.Count > 0)
            //{
            //    s.Id = Convert.ToInt32(dataTable.Rows[0][0].ToString());
            //    s.RollNo = dataTable.Rows[0][1].ToString();
            //    s.Name = dataTable.Rows[0][2].ToString();
            //    s.Age = Convert.ToInt32(dataTable.Rows[0][3].ToString());
            //    s.Address = dataTable.Rows[0][4].ToString();
            //    s.DistrictID = Convert.ToInt32(dataTable.Rows[0][5]);
            //    //s.DistrictName = dataTable.Rows[0][6].ToString();
            //}

            //rollNoTextBox.Text = s.RollNo;
            //nameTextBox.Text = s.Name;
            //ageTextBox.Text = s.Age.ToString();
            //addressTextBox.Text = s.Address;
            //districtComboBox.SelectedValue = s.DistrictID;
            //idTextBox.Text = s.Id.ToString();


            //sqlConnection.Close();
        }
    }
}
