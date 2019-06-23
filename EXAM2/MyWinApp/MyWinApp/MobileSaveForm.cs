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
            try
            {
                if (IMEITextBox.Text.Equals("") && IMEITextBox.Text.Length != 15)
                {
                    MessageBox.Show("Invalid Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool IsExistsIMEi = _mobileManager.IsExists(IMEITextBox.Text);
                    if (IsExistsIMEi)
                    {
                        MessageBox.Show("IMEI Exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (IMEITextBox.Text.Length != 15)
                {
                    MessageBox.Show("IMEI Number Must be 15 digit!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (nameTextBox.Text.Equals(""))
                {
                    MessageBox.Show("Invalid Name Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (PriceTextBox.Text.Equals(""))
                {
                    MessageBox.Show("Invalid Price Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                Mobile mobile = new Mobile();
                mobile.Name = nameTextBox.Text;
                mobile.IMEI = IMEITextBox.Text;
                mobile.Price = Convert.ToDouble(PriceTextBox.Text);

                _mobileManager.Insert(mobile);

                button1_Click(sender, e);

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
