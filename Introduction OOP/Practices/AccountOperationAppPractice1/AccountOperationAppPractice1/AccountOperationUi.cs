using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        Account accObj = new Account();
        public AccountOperationUi()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            

            accObj.accountNo = Convert.ToInt32(accountNoTextBox.Text);
            accObj.name = customerNameTextBox.Text;
            


        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);

            accObj.Diposite(amount);

            MessageBox.Show(accObj.name + " ,your account number sv-" + accObj.accountNo.ToString() + " and balance is " +
                            accObj.GetBalace().ToString());

            amountTextBox.Text = "";
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);

            accObj.Withdraw(amount);

            MessageBox.Show(accObj.name + " ,your account number sv-" + accObj.accountNo.ToString() + " and balance is " +
                            accObj.GetBalace().ToString());
            amountTextBox.Text = "";
        }
    }
}
