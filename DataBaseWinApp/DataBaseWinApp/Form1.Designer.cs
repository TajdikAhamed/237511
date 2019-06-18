namespace DataBaseWinApp
{
    partial class Form1
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.deptTextBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.displayDataGridView = new System.Windows.Forms.DataGridView();
            this.idTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(334, 71);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // deptTextBox
            // 
            this.deptTextBox.Location = new System.Drawing.Point(32, 73);
            this.deptTextBox.Name = "deptTextBox";
            this.deptTextBox.Size = new System.Drawing.Size(100, 20);
            this.deptTextBox.TabIndex = 1;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(160, 71);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeTextBox.TabIndex = 2;
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(334, 101);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 3;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // displayDataGridView
            // 
            this.displayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDataGridView.Location = new System.Drawing.Point(13, 174);
            this.displayDataGridView.Name = "displayDataGridView";
            this.displayDataGridView.Size = new System.Drawing.Size(408, 217);
            this.displayDataGridView.TabIndex = 4;
            this.displayDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayDataGridView_CellClick);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(32, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 5;
            this.idTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.displayDataGridView);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.deptTextBox);
            this.Controls.Add(this.SaveButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox deptTextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.DataGridView displayDataGridView;
        private System.Windows.Forms.TextBox idTextBox;
    }
}

