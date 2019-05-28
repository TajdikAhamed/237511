using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSWinApp
{
    public partial class Form3 : Form
    {
        List<string> usernames = new List<string>();
        List<string> names = new List<string>();
        List<int> ages = new List<int>();
        public Form3()
        {
            InitializeComponent();
            errorMessage.ForeColor = Color.Red;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorMessage.Text = "";
                string username = usernameTextBox.Text;
                string name = nameTextBox.Text;
                int age;

                if (string.IsNullOrEmpty(usernameTextBox.Text))
                {
                    usernameTextBox.BackColor = Color.Red;
                    errorMessage.Text = "Red field can not ne empty!";
                    return;
                }

                if (IsExists(username))
                {
                    usernameTextBox.BackColor = Color.Red;
                    errorMessage.Text = "Username already exists!";
                    return;
                }
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {

                    nameTextBox.BackColor = Color.Red;
                    errorMessage.Text = "Red field can not ne empty!";
                    return;
                }

                if (string.IsNullOrEmpty(ageTextBox.Text))
                {
                    ageTextBox.BackColor = Color.Red;
                    errorMessage.Text = "Red field can not ne empty!";
                    return;
                }



                age = Convert.ToInt32(ageTextBox.Text);
                ages.Add(age);
                names.Add(name);
                usernames.Add(username);


                displayRichTextBox.Text = Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private string Display()
        {
            string message = "Sl\tUsername\tName\tAge\n";
            int index = 0;
            foreach (string username in usernames)
            {
                message += (index+1)+"\t"+username+"\t\t"+names[index]+"\t"+ages[index]+"\n";
                index++;
            }


            return message;


        }

        private bool IsExists(string userName)
        {
            

            foreach (string username in usernames)
            {
                if (userName.Equals(username))
                {
                    return true;
                }
            }

            return false;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            usernameTextBox.BackColor = Color.White;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameTextBox.BackColor = Color.White;
        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {
            ageTextBox.BackColor = Color.White;
        }

        private void usernameTextBox_Click(object sender, EventArgs e)
        {
            usernameTextBox.BackColor = Color.White;
        }

        private void nameTextBox_Click(object sender, EventArgs e)
        {
            nameTextBox.BackColor = Color.White;
        }

        private void ageTextBox_Click(object sender, EventArgs e)
        {
            ageTextBox.BackColor = Color.White;
        }
    }
}
