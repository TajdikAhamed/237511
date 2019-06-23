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
            try
            {
                if (SearchIMEITextBox.Text.Equals(""))
                {
                    MessageBox.Show("Invalid Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (SearchIMEITextBox.Text.Length != 15)
                {
                    MessageBox.Show("IMEI Number Must be 15 digit!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool IsExistsIMEi = _mobileManager.IsExists(SearchIMEITextBox.Text);
                    if (!IsExistsIMEi)
                    {
                        MessageBox.Show("No data found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                Mobile mobile;
                string IMEI = SearchIMEITextBox.Text;
                mobile = _mobileManager.SearchByIMEI(IMEI);

                IMEITextBox.Text = mobile.IMEI;
                nameTextBox.Text = mobile.Name;
                priceTextBox.Text = mobile.Price.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MobileHome mobileHome = new MobileHome();
            mobileHome.Show();

            this.Hide();
        }
    }
}
