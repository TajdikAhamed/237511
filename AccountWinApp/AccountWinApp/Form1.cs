using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountWinApp
{
    public partial class Form1 : Form
    {
        List<string> listSoldierNos = new List<string>();
        List<string> listSoldierNames = new List<string>();
        List<int> listSoldierTarget1Scores = new List<int>();
        List<int> listSoldierTarget2Scores = new List<int>();
        List<int> listSoldierTarget3Scores = new List<int>();
        List<int> listSoldierTarget4Scores = new List<int>();

        bool flagSolderNo = true;
        bool flagSolderName = false;



        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(soldierNoTextBox.Text))
                {
                    errorDisplay.Text = "Invalid input Soldier no!";
                    errorDisplay.ForeColor = Color.Red;

                    return;
                }
                string soldierNo = soldierNoTextBox.Text;
                if (IsExists(soldierNo))
                {
                    errorDisplay.Text = "Soldier Already Exist";
                    errorDisplay.ForeColor = Color.Red;

                    return;
                }

                if (string.IsNullOrEmpty(SoldierNameTextBox.Text))
                {
                    errorDisplay.Text = "Invalid input Soldier Name!";
                    errorDisplay.ForeColor = Color.Red;

                    return;
                }
                if (string.IsNullOrEmpty(score1TextBox.Text))
                {
                    errorDisplay.Text = "Invalid input target score 1!";
                    errorDisplay.ForeColor = Color.Red;

                    return;
                }
                if (string.IsNullOrEmpty(score2TextBox.Text))
                {
                    errorDisplay.Text = "Invalid input target score 2!";
                    errorDisplay.ForeColor = Color.Red;

                    return;
                }
                if (string.IsNullOrEmpty(score3TextBox.Text))
                {
                    errorDisplay.Text = "Invalid input target score 3!";
                    errorDisplay.ForeColor = Color.Red;

                    return;
                }
                if (string.IsNullOrEmpty(score4TextBox.Text))
                {
                    errorDisplay.Text = "Invalid input target score 4!";
                    errorDisplay.ForeColor = Color.Red;

                    return;
                }
                int score1;
                int score2;
                int score3;
                int score4;
                if (!int.TryParse(score1TextBox.Text, out score1))
                {
                    errorDisplay.Text = "target score 1 need to numaric!";
                    errorDisplay.ForeColor = Color.Red;

                    return;
                }
                if (!int.TryParse(score2TextBox.Text, out score2))
                {
                    errorDisplay.Text = "target score 2 need to numaric!";
                    errorDisplay.ForeColor = Color.Red;

                    return;
                }
                if (!int.TryParse(score3TextBox.Text, out score3))
                {
                    errorDisplay.Text = "target score 3 need to numaric!";
                    errorDisplay.ForeColor = Color.Red;

                    return;
                }
                if (!int.TryParse(score4TextBox.Text, out score4))
                {
                    errorDisplay.Text = "target score 4 need to numaric!";
                    errorDisplay.ForeColor = Color.Red;

                    return;
                }


                string soldierName = SoldierNameTextBox.Text;
                int target1 = Convert.ToInt32(score1TextBox.Text);
                int target2 = Convert.ToInt32(score2TextBox.Text);
                int target3 = Convert.ToInt32(score3TextBox.Text);
                int target4 = Convert.ToInt32(score4TextBox.Text);


                listSoldierNos.Add(soldierNo);
                listSoldierNames.Add(soldierName);
                listSoldierTarget1Scores.Add(target1);
                listSoldierTarget2Scores.Add(target2);
                listSoldierTarget3Scores.Add(target3);
                listSoldierTarget4Scores.Add(target4);


                errorDisplay.Text = "Soldier Information added";
                errorDisplay.ForeColor = Color.Green;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void soldierNoRadioButton_Click(object sender, EventArgs e)
        {
            flagSolderNo = true;
            flagSolderName = false;

        }

        private void soldierNameRadioButton_Click(object sender, EventArgs e)
        {
            flagSolderNo = false;
            flagSolderName = true;
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            float maxAvg = 0;
            int maxTotal = 0;
            string message = "\tSoldier No. | \tSoldier Name |\tAverage Score |\tTotal Score\n";
            int index = 0;
            foreach (var solderNo in listSoldierNos)
            {
                int total = listSoldierTarget1Scores[index] + listSoldierTarget2Scores[index] + listSoldierTarget3Scores[index] + listSoldierTarget4Scores[index];
                float avg = total / 4;
                message += "\t"+solderNo+" |\t"+listSoldierNames[index]+" |\t"+ avg + " |\t"+ total + " |\n";
                if (avg > maxAvg)
                {
                    maxAvg = avg;
                }
                if (total > maxTotal)
                {
                    maxTotal = total;
                }
                index++;
            }

            

            displayRichTextBox.Text = message;
            topAvgTextBox.Text = maxAvg.ToString();
            topTotalTextBox.Text = maxTotal.ToString();
        }

        bool IsExists(string SoldierNo)
        {
            int index = 0;
            foreach (var solderNo in listSoldierNos)
            {
                if (SoldierNo.Equals(solderNo))
                {
                    return true;
                }
                index++;
            }

            return false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try {
                string message = "\tSoldier No. | \tSoldier Name |\tAverage Score |\tTotal Score\n";
                string search = searchTextBox.Text;
                if (flagSolderNo)
                {
                    int index = 0;
                    foreach (var solderNo in listSoldierNos)
                    {
                        if (search.Equals(solderNo))
                        {
                            int total = listSoldierTarget1Scores[index] + listSoldierTarget2Scores[index] + listSoldierTarget3Scores[index] + listSoldierTarget4Scores[index];
                            float avg = total / 4;
                            message += "\t" + solderNo + " |\t" + listSoldierNames[index] + " |\t" + avg + " |\t" + total + " |\n";
                        }
                        index++;
                    }
                    displayRichTextBox.Text = message;
                }
                else if (flagSolderName)
                {
                    int index = 0;
                    foreach (var solderNo in listSoldierNos)
                    {
                        if (search.Equals(listSoldierNames[index]))
                        {
                            int total = listSoldierTarget1Scores[index] + listSoldierTarget2Scores[index] + listSoldierTarget3Scores[index] + listSoldierTarget4Scores[index];
                            float avg = total / 4;
                            message += "\t" + solderNo + " |\t" + listSoldierNames[index] + " |\t" + avg + " |\t" + total + " |\n";
                        }
                        index++;
                    }
                    displayRichTextBox.Text = message;
                }
            }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
