using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        Refrigerator Refrigerator;
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            double maxWeight = Convert.ToDouble(maxWeightTakeTextBox.Text);
            Refrigerator = new Refrigerator(maxWeight);
            maxWeightTakeTextBox.Text = "";
            Show();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            int itemQ = Convert.ToInt32(itemTextBox.Text);
            double Weight = Convert.ToDouble(weightTextBox.Text);

            bool flag = Refrigerator.PutItems(itemQ, Weight);
            if (flag)
            {
                Show();
            }
            else
            {
                MessageBox.Show("Your given amount can’t be entered because it will be over flown.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            
        }
        private void Show()
        {
            currentWeightTextBox.Text = Refrigerator.CureentWeight.ToString();
            double rem = Refrigerator.GetRemain();
            remainingWeightTextBox.Text = rem.ToString();

        }

        
    }
}
