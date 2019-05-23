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
    public partial class Form1 : Form
    {
        const int size = 100;
        int[] number = new int[size];
        int index2 = 0;

        const int size3 = 100;
        int[] number3 = new int[size3];
        int index3 = 0;
        public Form1()
        {
            InitializeComponent();
            /*
            const int size = 10;
            int[] number = new int[size];

            number[0] = 3;
            number[2] = 4;
            number[4] = 9;
            string message = "";
            for (int index = 0; index < size; index++)
            {
                if (number[index] !=0)
                {
                    message = message + "Value of index " + index.ToString() + " :" + number[index].ToString() + "\n";
                }
            }



            richTextBox1.Text = message;
            */

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {



            string message = "";
            message += "Disply : \n";
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                {
                    message = message + "Value of index " + index.ToString() + " :" + number[index].ToString() + "\n";
                }
            }




            richTextBox1.AppendText(message);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            number[index2] = Convert.ToInt32(inputTextBox.Text);
            index2++;
            inputTextBox.Text = "";

            string message = "";
            //message += "Input Value : \n";

       
                    message = message + "Input Value in index " + index2.ToString() + " :" + number[index2-1].ToString() + "\n";

            //richTextBox1.Text = message;
            richTextBox1.AppendText(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string message = "";
            message += "Disply in Reverse : \n";
            for (int index = number.Length - 1; index >= 0; index--)
            {
                if (number[index] != 0)
                {
                    message = message + "Value of index " + index.ToString() + " :" + number[index].ToString() + "\n";
                }
            }

            richTextBox1.AppendText(message);

        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                {
                    sum += number[index];
                }
            }

            richTextBox1.AppendText("\nSum of the array value :"+ sum.ToString()+"\n");
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                {
                    number3[index]  = number[index];
                }
            }
            richTextBox1.AppendText("Done Copy One array to Another\n");
        }

        private void ShowDupButton_Click(object sender, EventArgs e)
        {

            string message = "";
            message += "Disply Copy One : \n";
            for (int index = 0; index < number.Length; index++)
            {
                if (number3[index] != 0)
                {
                    message = message + "Value of index " + index.ToString() + " :" + number3[index].ToString() + "\n";
                }
            }
            richTextBox1.AppendText(message);
        }
    }
}
