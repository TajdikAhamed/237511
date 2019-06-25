using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class MobileHome : Form
    {
        public MobileHome()
        {
            InitializeComponent();
        }

        private void MobileHome_Load(object sender, EventArgs e)
        {

        }

        private void SaveMobile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MobileSaveForm mobileSaveForm = new MobileSaveForm();
            mobileSaveForm.Show();

            this.Hide();
        }

        private void SearchMobileByPrice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchByPriceForm searchByPriceForm = new SearchByPriceForm();
            searchByPriceForm.Show();

            this.Hide();
        }

        private void SearchMobileIMEI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchByIMEIForm searchByImeiForm = new SearchByIMEIForm();
            searchByImeiForm.Show();

            this.Hide();
        }
    }
}
