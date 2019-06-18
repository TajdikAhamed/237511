using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            {
                //1
                string name = nameTextBox.Text;
                string regNo = regNoTextBox.Text;
                string address = addressTextBox.Text;
                string conatactNo = contactNoTextBox.Text;
                // int departmentId = Convert.ToInt32(departmentIdTextBox.Text);
                int departmentId = Convert.ToInt32(departmentComboBox.SelectedValue);

                if (Exists(regNo))
                {
                    MessageBox.Show("Exists");
                    return;

                }

                try
                {

                    //2
                    string connectionString = @"Server=BITM-TRAINER-PC; Database=StudenDb; Integrated Security = true ";
                    //3
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    //4
                    string query = @"INSERT INTO Students (Name, Address, ContactNo,  RegNo, DepartmentId) VALUES ('" + name + "','" + address + "','" + conatactNo + "','" + regNo + "'," + departmentId + ")";
                    //5
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    //6
                    sqlConnection.Open();
                    //7
                    int isExecuted = sqlCommand.ExecuteNonQuery();
                    if (isExecuted > 0)
                    {
                        MessageBox.Show("Saved");
                    }
                    else
                    {
                        MessageBox.Show("Not Saved");
                    }
                    //8
                    sqlConnection.Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }

            private void ShowButton_Click(object sender, EventArgs e)
            {
                try
                {

                    //2
                    string connectionString = @"Server=BITM-TRAINER-PC; Database=StudenDb; Integrated Security = true ";
                    //3
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    //4
                    string query = @"SELECT * FROM StudentView";
                    //5
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    //6
                    sqlConnection.Open();
                    //7


                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        showDataGridView.DataSource = dataTable;
                    }
                    else
                        showDataGridView.DataSource = null;

                    //8
                    sqlConnection.Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            private void UpdateButton_Click(object sender, EventArgs e)
            {
                //1
                string name = nameTextBox.Text;
                string regNo = regNoTextBox.Text;
                string address = addressTextBox.Text;
                string conatactNo = contactNoTextBox.Text;
                int departmentId = Convert.ToInt32(departmentIdTextBox.Text);

                int id = Convert.ToInt32(idTextBox.Text);
                try
                {
                    //2
                    string connectionString = @"Server=BITM-TRAINER-PC; Database=StudenDb; Integrated Security = true ";
                    //3
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    //4
                    string query = @"UPDATE Students SET Name = '" + name + "', Address = '" + address + "', ContactNo = '" + conatactNo + "', RegNo = '" + regNo + "', DepartmentId = " + departmentId + "  WHERE ID =" + id + " ";
                    //5
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    //6
                    sqlConnection.Open();
                    //7
                    int isExecuted = sqlCommand.ExecuteNonQuery();
                    if (isExecuted > 0)
                    {
                        MessageBox.Show("Upadated");
                    }
                    else
                    {
                        MessageBox.Show("Not Upadated");
                    }
                    //8
                    sqlConnection.Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            private void DeleteButton_Click(object sender, EventArgs e)
            {
                int id = Convert.ToInt32(idTextBox.Text);

                try
                {

                    //2
                    string connectionString = @"Server=BITM-TRAINER-PC; Database=StudenDb; Integrated Security = true ";
                    //3
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    //4
                    string query = @"DELETE FROM Students  WHERE ID =" + id + " ";
                    //5
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    //6
                    sqlConnection.Open();
                    //7
                    int isExecuted = sqlCommand.ExecuteNonQuery();
                    if (isExecuted > 0)
                    {
                        MessageBox.Show("Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Not Deleted");
                    }
                    //8
                    sqlConnection.Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            private void FindButton_Click(object sender, EventArgs e)
            {
                int id = Convert.ToInt32(idTextBox.Text);
                try
                {

                    //2
                    string connectionString = @"Server=BITM-TRAINER-PC; Database=StudenDb; Integrated Security = true ";
                    //3
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    //4
                    string query = @"SELECT * FROM StudentView WHERE ID=" + id + "";
                    //5
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    //6
                    sqlConnection.Open();
                    //7


                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        showDataGridView.DataSource = dataTable;
                    }
                    else
                        showDataGridView.DataSource = null;

                    //8
                    sqlConnection.Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            private bool Exists(string regNo)
            {
                bool isExists = false;

                try
                {

                    //2
                    string connectionString = @"Server=BITM-TRAINER-PC; Database=StudenDb; Integrated Security = true ";
                    //3
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    //4
                    string query = @"SELECT * FROM StudentView WHERE RegNo='" + regNo + "'";
                    //5
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    //6
                    sqlConnection.Open();
                    //7


                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        isExists = true;
                    }
                    else
                        isExists = false;

                    //8
                    sqlConnection.Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

                return isExists;
            }

            private void StudentInformationUi_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'studenDbDataSet.Department' table. You can move, or remove it, as needed.
                this.departmentTableAdapter.Fill(this.studenDbDataSet.Department);

            }
        }
    }using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseApp
    {
        public partial class StudentInformationUi : Form
        {
            public StudentInformationUi()
            {
                InitializeComponent();
            }

            private void SaveButton_Click(object sender, EventArgs e)
            {
                //1
                string name = nameTextBox.Text;
                string regNo = regNoTextBox.Text;
                string address = addressTextBox.Text;
                string conatactNo = contactNoTextBox.Text;
                // int departmentId = Convert.ToInt32(departmentIdTextBox.Text);
                int departmentId = Convert.ToInt32(departmentComboBox.SelectedValue);

                if (Exists(regNo))
                {
                    MessageBox.Show("Exists");
                    return;

                }

                try
                {

                    //2
                    string connectionString = @"Server=BITM-TRAINER-PC; Database=StudenDb; Integrated Security = true ";
                    //3
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    //4
                    string query = @"INSERT INTO Students (Name, Address, ContactNo,  RegNo, DepartmentId) VALUES ('" + name + "','" + address + "','" + conatactNo + "','" + regNo + "'," + departmentId + ")";
                    //5
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    //6
                    sqlConnection.Open();
                    //7
                    int isExecuted = sqlCommand.ExecuteNonQuery();
                    if (isExecuted > 0)
                    {
                        MessageBox.Show("Saved");
                    }
                    else
                    {
                        MessageBox.Show("Not Saved");
                    }
                    //8
                    sqlConnection.Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }

            private void ShowButton_Click(object sender, EventArgs e)
            {
                try
                {

                    //2
                    string connectionString = @"Server=BITM-TRAINER-PC; Database=StudenDb; Integrated Security = true ";
                    //3
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    //4
                    string query = @"SELECT * FROM StudentView";
                    //5
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    //6
                    sqlConnection.Open();
                    //7


                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        showDataGridView.DataSource = dataTable;
                    }
                    else
                        showDataGridView.DataSource = null;

                    //8
                    sqlConnection.Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            private void UpdateButton_Click(object sender, EventArgs e)
            {
                //1
                string name = nameTextBox.Text;
                string regNo = regNoTextBox.Text;
                string address = addressTextBox.Text;
                string conatactNo = contactNoTextBox.Text;
                int departmentId = Convert.ToInt32(departmentIdTextBox.Text);

                int id = Convert.ToInt32(idTextBox.Text);
                try
                {
                    //2
                    string connectionString = @"Server=BITM-TRAINER-PC; Database=StudenDb; Integrated Security = true ";
                    //3
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    //4
                    string query = @"UPDATE Students SET Name = '" + name + "', Address = '" + address + "', ContactNo = '" + conatactNo + "', RegNo = '" + regNo + "', DepartmentId = " + departmentId + "  WHERE ID =" + id + " ";
                    //5
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    //6
                    sqlConnection.Open();
                    //7
                    int isExecuted = sqlCommand.ExecuteNonQuery();
                    if (isExecuted > 0)
                    {
                        MessageBox.Show("Upadated");
                    }
                    else
                    {
                        MessageBox.Show("Not Upadated");
                    }
                    //8
                    sqlConnection.Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            private void DeleteButton_Click(object sender, EventArgs e)
            {
                int id = Convert.ToInt32(idTextBox.Text);

                try
                {

                    //2
                    string connectionString = @"Server=BITM-TRAINER-PC; Database=StudenDb; Integrated Security = true ";
                    //3
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    //4
                    string query = @"DELETE FROM Students  WHERE ID =" + id + " ";
                    //5
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    //6
                    sqlConnection.Open();
                    //7
                    int isExecuted = sqlCommand.ExecuteNonQuery();
                    if (isExecuted > 0)
                    {
                        MessageBox.Show("Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Not Deleted");
                    }
                    //8
                    sqlConnection.Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            private void FindButton_Click(object sender, EventArgs e)
            {
                int id = Convert.ToInt32(idTextBox.Text);
                try
                {

                    //2
                    string connectionString = @"Server=BITM-TRAINER-PC; Database=StudenDb; Integrated Security = true ";
                    //3
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    //4
                    string query = @"SELECT * FROM StudentView WHERE ID=" + id + "";
                    //5
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    //6
                    sqlConnection.Open();
                    //7


                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        showDataGridView.DataSource = dataTable;
                    }
                    else
                        showDataGridView.DataSource = null;

                    //8
                    sqlConnection.Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            private bool Exists(string regNo)
            {
                bool isExists = false;

                try
                {

                    //2
                    string connectionString = @"Server=BITM-TRAINER-PC; Database=StudenDb; Integrated Security = true ";
                    //3
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    //4
                    string query = @"SELECT * FROM StudentView WHERE RegNo='" + regNo + "'";
                    //5
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    //6
                    sqlConnection.Open();
                    //7


                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        isExists = true;
                    }
                    else
                        isExists = false;

                    //8
                    sqlConnection.Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

                return isExists;
            }

            private void StudentInformationUi_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'studenDbDataSet.Department' table. You can move, or remove it, as needed.
                this.departmentTableAdapter.Fill(this.studenDbDataSet.Department);

            }
        }
    }

