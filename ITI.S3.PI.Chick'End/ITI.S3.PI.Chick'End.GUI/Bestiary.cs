﻿using System;
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
    public partial class Bestiary : Form
    {
        Controler _controler;

        public Bestiary( Controler controler )
        {
            InitializeComponent();
            _controler = controler;
        }

        private void buttonReturn_Click( object sender, EventArgs e )
        {
            _controler.HideBestiary();
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
    }
}
