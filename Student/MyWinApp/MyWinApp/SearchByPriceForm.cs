using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWinApp.BLL;

namespace MyWinApp
{
    public partial class SearchByPriceForm : Form
    {
        MobileManager _mobileManager = new MobileManager();
        public SearchByPriceForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            double Low = Convert.ToDouble(FirstPriceTextBox.Text);
            double High = Convert.ToDouble(SecondPriceTextBox.Text);

            if (Low > High)
            {
               SearchDataGridView.DataSource =  _mobileManager.SearchByPrice(High, Low);
            }
            else
            {
                SearchDataGridView.DataSource = _mobileManager.SearchByPrice(Low, High);
            }


            for (int i = 0; i < SearchDataGridView.Rows.Count - 1; i++)
            {
                SearchDataGridView.Rows[i].Cells[1].Value = (i + 1).ToString();
            }


        }
    }
}
