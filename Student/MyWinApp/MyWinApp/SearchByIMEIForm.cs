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
using MyWinApp.Models;

namespace MyWinApp
{
    public partial class SearchByIMEIForm : Form
    {
        MobileManager _mobileManager = new MobileManager();
        public SearchByIMEIForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Mobile mobile;
            string IMEI = SearchIMEITextBox.Text;
            mobile = _mobileManager.SearchByIMEI(IMEI);

            IMEITextBox.Text = mobile.IMEI;
            nameTextBox.Text = mobile.Name;
            priceTextBox.Text = mobile.Price.ToString();

        }
    }
}
