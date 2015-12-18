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
            Xml Xml = new Xml();
            List<Result> _results = Xml.LoadFromFile("leaderboard.xml");

            int i, j;
            List<Result> tmp = new List<Result>();
            tmp.Add(_results[0]);
            for (j = 0; j < _results.Count(); j++)
            {
                for (i = 0; i < _results.Count() - 1; i++)
                {
                    if (Convert.ToInt32(_results[i].ScoreR) < Convert.ToInt32(_results[i+1].ScoreR))
                    {
                        tmp[0] = _results[i];
                        _results[i] = _results[i + 1];
                        _results[i + 1] = tmp[0];
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

            for (i = 0; i < _results.Count(); i++)
            {
                if (_results[i].LevelR == "1")
                {
                    labelPseudoOne.Text += _results[i].PseudoR + "\n\n";
                    labelScoreOne.Text += _results[i].ScoreR.Insert(2, ":") + "\n\n";
                }
                else if (_results[i].LevelR == "2")
                {
                    labelPseudoTwo.Text += _results[i].PseudoR + "\n\n";
                    labelScoreTwo.Text += _results[i].ScoreR.Insert(2, ":") + "\n\n";
                }
                else if (_results[i].LevelR == "3")
                {
                    labelPseudoThree.Text += _results[i].PseudoR + "\n\n";
                    labelScoreThree.Text += _results[i].ScoreR.Insert(2, ":") + "\n\n";
                }
                else if (_results[i].LevelR == "4")
                {
                    labelPseudoFour.Text += _results[i].PseudoR + "\n\n";
                    labelScoreFour.Text += _results[i].ScoreR.Insert(2, ":") + "\n\n";
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