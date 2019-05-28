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
    public partial class Form2 : Form
    {
        List<int> numbers = new List<int>();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numbers.Add(Convert.ToInt32(textBox1.Text));
            richTextBox1.AppendText("Value added : "+  textBox1.Text+"\n");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "";
            foreach (var number in numbers)
            {
                message += "Value : "+number.ToString()+"\n";
            }

            richTextBox1.AppendText("Display: \n"+message+"\n");
        }
    }
}
