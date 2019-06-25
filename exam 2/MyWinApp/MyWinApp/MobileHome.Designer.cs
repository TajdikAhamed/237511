namespace MyWinApp
{
    partial class MobileHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveMobile = new System.Windows.Forms.LinkLabel();
            this.SearchMobileByPrice = new System.Windows.Forms.LinkLabel();
            this.SearchMobileIMEI = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchMobileIMEI);
            this.groupBox1.Controls.Add(this.SearchMobileByPrice);
            this.groupBox1.Controls.Add(this.SaveMobile);
            this.groupBox1.Location = new System.Drawing.Point(93, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Index";
            // 
            // SaveMobile
            // 
            this.SaveMobile.AutoSize = true;
            this.SaveMobile.Location = new System.Drawing.Point(113, 37);
            this.SaveMobile.Name = "SaveMobile";
            this.SaveMobile.Size = new System.Drawing.Size(164, 13);
            this.SaveMobile.TabIndex = 0;
            this.SaveMobile.TabStop = true;
            this.SaveMobile.Text = "Save Mobile Handset Information";
            this.SaveMobile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SaveMobile_LinkClicked);
            // 
            // SearchMobileByPrice
            // 
            this.SearchMobileByPrice.AutoSize = true;
            this.SearchMobileByPrice.Location = new System.Drawing.Point(98, 75);
            this.SearchMobileByPrice.Name = "SearchMobileByPrice";
            this.SearchMobileByPrice.Size = new System.Drawing.Size(194, 13);
            this.SearchMobileByPrice.TabIndex = 1;
            this.SearchMobileByPrice.TabStop = true;
            this.SearchMobileByPrice.Text = "Search Mobile Handset by Price Range";
            this.SearchMobileByPrice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SearchMobileByPrice_LinkClicked);
            // 
            // SearchMobileIMEI
            // 
            this.SearchMobileIMEI.AutoSize = true;
            this.SearchMobileIMEI.Location = new System.Drawing.Point(113, 121);
            this.SearchMobileIMEI.Name = "SearchMobileIMEI";
            this.SearchMobileIMEI.Size = new System.Drawing.Size(157, 13);
            this.SearchMobileIMEI.TabIndex = 2;
            this.SearchMobileIMEI.TabStop = true;
            this.SearchMobileIMEI.Text = "Search Mobile Handset by IMEI";
            this.SearchMobileIMEI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SearchMobileIMEI_LinkClicked);
            // 
            // MobileHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 321);
            this.Controls.Add(this.groupBox1);
            this.Name = "MobileHome";
            this.Text = "MobileHome";
            this.Load += new System.EventHandler(this.MobileHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel SearchMobileIMEI;
        private System.Windows.Forms.LinkLabel SearchMobileByPrice;
        private System.Windows.Forms.LinkLabel SaveMobile;
    }
}