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
            string[,] table = { { "azsher", "02'57","1" }, { "legannon", "67'30","2" }, { "Monart", "10'25", "3" } };

            labelPseudoOne.Text = "";
            labelScoreOne.Text = "";
            labelPseudoTwo.Text = "";
            labelScoreTwo.Text = "";
            labelPseudoThree.Text = "";
            labelScoreThree.Text = "";
            labelPseudoFour.Text = "";
            labelScoreFour.Text = "";

            for (int i=0; i < table.Length/3; i++)
            {
                if (table[i, 2] == "1")
                {
                    labelPseudoOne.Text += table[i, 0] + "\n\n";
                    labelScoreOne.Text += table[i, 1] + "\n\n";
                }
                else if (table[i, 2] == "2")
                {
                    labelPseudoTwo.Text += table[i, 0] + "\n\n";
                    labelScoreTwo.Text += table[i, 1] + "\n\n";
                }
                else if (table[i, 2] == "3")
                {
                    labelPseudoThree.Text += table[i, 0] + "\n\n";
                    labelScoreThree.Text += table[i, 1] + "\n\n";
                }
                else if (table[i, 2] == "4")
                {
                    labelPseudoFour.Text += table[i, 0] + "\n\n";
                    labelScoreFour.Text += table[i, 1] + "\n\n";
                }
                else
                {
                    throw new Exception();
                }
            }    
        }
    }
}
