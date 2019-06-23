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
    public partial class MobileSaveForm : Form
    {
        MobileManager _mobileManager = new MobileManager();
        public MobileSaveForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Mobile mobile = new Mobile();

            mobile.Name = nameTextBox.Text;
            mobile.IMEI = IMEITextBox.Text;
            mobile.Price = Convert.ToDouble(PriceTextBox.Text);

            _mobileManager.Insert(mobile);

        }
    }
}
