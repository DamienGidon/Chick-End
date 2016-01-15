using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ITI.S3.PI.Chick_End.GUI
{
    public partial class Leaderboard : Form
    {
        Controler _controler;

        public Leaderboard( Controler controler )
        {
            InitializeComponent();

            _controler = controler;

            showScore();
        }

        private void buttonReturn_Click( object sender, EventArgs e )
        {
            _controler.HideLeaderbord();
        }

        private void buttonReturn_MouseEnter( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize( sender, 23F );
        }

        private void buttonReturn_MouseLeave( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize( sender, 20F );
        }

        private void showScore()
        {
            Xml Xml = new Xml();
            string _noScores = "No scores are registered";

            if (File.Exists("leaderboard.xml"))
            {
                List<Result> _results = Xml.LoadFromFile("leaderboard.xml");

                int i, j;
                List<Result> tmp = new List<Result>();
                tmp.Add(_results[0]);
                for (j = 0; j < _results.Count(); j++)
                {
                    for (i = 0; i < _results.Count() - 1; i++)
                    {
                        if (Convert.ToInt32(_results[i].ScoreR) < Convert.ToInt32(_results[i + 1].ScoreR))
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
                    if (_results[i].LevelR == 1)
                    {
                        labelPseudoOne.Text += _results[i].PseudoR + "\n\n";
                        labelScoreOne.Text += _results[i].ScoreR.Insert(2, ":") + "\n\n";
                    }
                    else if (_results[i].LevelR == 2)
                    {
                        labelPseudoTwo.Text += _results[i].PseudoR + "\n\n";
                        labelScoreTwo.Text += _results[i].ScoreR.Insert(2, ":") + "\n\n";
                    }
                    else if (_results[i].LevelR == 3)
                    {
                        labelPseudoThree.Text += _results[i].PseudoR + "\n\n";
                        labelScoreThree.Text += _results[i].ScoreR.Insert(2, ":") + "\n\n";
                    }
                    else if (_results[i].LevelR == 4)
                    {
                        labelPseudoFour.Text += _results[i].PseudoR + "\n\n";
                        labelScoreFour.Text += _results[i].ScoreR.Insert(2, ":") + "\n\n";
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            if (labelPseudoOne.Text == "") { labelVide1.Text = _noScores; labelPseudo.Hide(); labelScore.Hide(); } else labelVide1.Hide();
            if (labelPseudoTwo.Text == "") { labelVide2.Text = _noScores; label1.Hide(); label2.Hide(); } else labelVide2.Hide();
            if (labelPseudoThree.Text == "") { labelVide3.Text = _noScores; label3.Hide(); label4.Hide(); } else labelVide3.Hide();
            if (labelPseudoFour.Text == "") { labelVide4.Text = _noScores; label5.Hide(); label6.Hide(); } else labelVide4.Hide();
        }

        public void ActualiseLeaderboard()
        {
            showScore();
        }
    }
}