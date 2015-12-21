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
    public partial class Rules : Form
    {
        Controler _controler;

        public Rules( Controler controler )
        {
            InitializeComponent();

            _controler = controler;

            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
            //richTextBox3.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void buttonReturn_Click( object sender, EventArgs e )
        {
            _controler.HideRules();
        }

        private void buttonReturn_MouseEnter( object sender, EventArgs e )
        {
            buttonReturn.Font = new System.Drawing.Font( "Playbill", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            buttonReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonReturn.Refresh();
        }

        private void buttonReturn_MouseLeave( object sender, EventArgs e )
        {
            buttonReturn.Font = new System.Drawing.Font( "Playbill", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            buttonReturn.Refresh();
        }

        private void label1_Click( object sender, EventArgs e )
        {

        }

        private void richTextBox2_TextChanged( object sender, EventArgs e )
        {

        }

        private void pictureBox3_Click( object sender, EventArgs e )
        {

        }

        private void richTextBox1_TextChanged( object sender, EventArgs e )
        {

        }

        private void pictureBox1_Click( object sender, EventArgs e )
        {

        }

        private void pictureBox2_Click( object sender, EventArgs e )
        {

        }

        private void richTextBox3_TextChanged( object sender, EventArgs e )
        {

        }
    }
}
