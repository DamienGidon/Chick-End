using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI.S3.PI.Chick_End.GUI
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
            showScore();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonReturn_MouseEnter(object sender, EventArgs e)
        {
            buttonReturn.Font = new System.Drawing.Font("Playbill", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonReturn.Refresh();
        }

        private void buttonReturn_MouseLeave(object sender, EventArgs e)
        {
            buttonReturn.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonReturn.Refresh();
        }

        private void showScore()
        {
            string _noScores = "No scores are registered";
            string[,] table = { { "Azsher", "0257","1" }, { "Legannon", "6730","2" }, { "Monart", "1025", "3" }, { "Wetcher", "1225", "2" }, { "Suaremente", "1025", "1" } };

            int i, j;
            string[,] tmp = { { "Azsher", "0257", "1" } };

            for (j = 0; j < (table.Length/3); j++)
            {
                for (i = 0; i < (table.Length/3) - 1; i++)
                {
                    if (Convert.ToInt32(table[i,1]) < Convert.ToInt32(table[i + 1,1]))
                    {
                        tmp[0, 0] = table[i,0];
                        tmp[0, 1] = table[i, 1];
                        tmp[0, 2] = table[i, 2];

                        table[i, 0] = table[i + 1, 0];
                        table[i, 1] = table[i + 1, 1];
                        table[i, 2] = table[i + 1, 2];

                        table[i + 1, 0] = tmp[0, 0];
                        table[i + 1, 1] = tmp[0, 1];
                        table[i + 1, 2] = tmp[0, 2];
                    }
                }
            }

            labelPseudoOne.Text = "";
            labelScoreOne.Text = "";
            labelPseudoTwo.Text = "";
            labelScoreTwo.Text = "";
            labelPseudoThree.Text = "";
            labelScoreThree.Text = "";
            labelPseudoFour.Text = "";
            labelScoreFour.Text = "";

            for (i=0; i < table.Length/3; i++)
            {
                if (table[i, 2] == "1")
                {
                    labelPseudoOne.Text += table[i, 0] + "\n\n";
                    labelScoreOne.Text += table[i, 1].Insert(2, ":") + "\n\n";
                }
                else if (table[i, 2] == "2")
                {
                    labelPseudoTwo.Text += table[i, 0] + "\n\n";
                    labelScoreTwo.Text += table[i, 1].Insert(2, ":") + "\n\n";
                }
                else if (table[i, 2] == "3")
                {
                    labelPseudoThree.Text += table[i, 0] + "\n\n";
                    labelScoreThree.Text += table[i, 1].Insert(2, ":") + "\n\n";
                }
                else if (table[i, 2] == "4")
                {
                    labelPseudoFour.Text += table[i, 0] + "\n\n";
                    labelScoreFour.Text += table[i, 1].Insert(2, ":") + "\n\n";
                }
                else
                {
                    throw new Exception();
                }
            }
            if (labelPseudoOne.Text == "") { labelVide1.Text = _noScores; labelPseudo.Hide(); labelScore.Hide(); } else labelVide1.Hide();
            if (labelPseudoTwo.Text == "") { labelVide2.Text = _noScores; label1.Hide(); label2.Hide(); } else labelVide2.Hide();
            if (labelPseudoThree.Text == "") { labelVide3.Text = _noScores; label3.Hide(); label4.Hide(); } else labelVide3.Hide();
            if (labelPseudoFour.Text == "") { labelVide4.Text = _noScores; label5.Hide(); label6.Hide(); } else labelVide4.Hide();
        }
    }
}