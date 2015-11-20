﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ITI.S3.PI.Chick_End.GUI
{
    public partial class gamecontrol : UserControl
    {
        Panel _panel;
        public gamecontrol(Panel panel)
        {
            InitializeComponent();
            _panel = panel;
            Bitmap p = new Bitmap(@"HenLeft.png");
            Graphics g = Graphics.FromImage(p);
            g.DrawImage(p, 60, 60);
            pictureBox1.Image = p;

            pictureBox1.DragDrop += new DragEventHandler(pictureBox1_DragDrop);
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            viewMapControler1.DragEnter += new DragEventHandler(viewMapControler1_DragEnter);
            panel1.DragEnter += new DragEventHandler(viewMapControler1_DragEnter);

            pictureBox1.AllowDrop = true;
            viewMapControler1.AllowDrop = true;
            panel1.AllowDrop = true;
        }
        
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Show();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();

            _panel.Show();
        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
        }

        // Code d'affichage des boutons

        private void buttonBestiary_MouseEnter(object sender, EventArgs e)
        {
            buttonBestiary.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonBestiary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonBestiary.Refresh();
        }

        private void buttonBestiary_MouseLeave(object sender, EventArgs e)
        {
            buttonBestiary.Font = new System.Drawing.Font("Playbill", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonBestiary.Refresh();
        }

        private void buttonResume_MouseEnter(object sender, EventArgs e)
        {
            buttonResume.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonResume.Refresh();
        }

        private void buttonResume_MouseLeave(object sender, EventArgs e)
        {
            buttonResume.Font = new System.Drawing.Font("Playbill", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonResume.Refresh();
        }

        private void buttonMenu_MouseEnter(object sender, EventArgs e)
        {
            buttonMenu.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonMenu.Refresh();
        }

        private void buttonMenu_MouseLeave(object sender, EventArgs e)
        {
            buttonMenu.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonMenu.Refresh();
        }

        private void buttonTrash_MouseEnter(object sender, EventArgs e)
        {
            buttonTrash.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonTrash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonTrash.Refresh();
        }

        private void buttonTrash_MouseLeave(object sender, EventArgs e)
        {
            buttonTrash.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonTrash.Refresh();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            int x = 100;
            int y = 100;

            for (int i = 0; i < FinalVariables._nbCaseHeight; i++)
            {
                for (int j = 0; j < FinalVariables._nbCaseWidth; j++)
                {
                    if(viewMapControler1.Context.Map.Square[i,j] != null)
                    {
                        string directory = Path.GetDirectoryName(Application.ExecutablePath);
                        string HenLeft = Path.Combine(directory, @"HenLeft.png");

                        Image ImageHenLeft = Image.FromFile(HenLeft);
                        e.Graphics.DrawImage(ImageHenLeft, x, y, 50, 50);
                    }
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = ((PictureBox)sender);
            pb.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void viewMapControler1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = ((PictureBox)sender);
            pb.Select();
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);

            var relativePoint = viewMapControler1.PointToClient(Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y));
            int topLeftCornerX = ((relativePoint.X / 50)*50);
            int topLeftCornerY = ((relativePoint.Y / 50)*50);
            int line = topLeftCornerY / 50;
            int column = topLeftCornerX / 50;

            if (viewMapControler1.Context.Map.Square[line, column].Decoration != "path" || viewMapControler1.Context.Map.Square[line, column].Tower != null)
            {
                MessageBox.Show("Non");
            }
            else
            {

                Bitmap p2 = new Bitmap(@"HenLeft.png");
                Graphics g = Graphics.FromImage(p2);

                Rectangle r = new Rectangle(topLeftCornerX, topLeftCornerY, 50, 50);
                PaintEventArgs e1 = new PaintEventArgs(viewMapControler1.CreateGraphics(), r);
                e1.Graphics.DrawImage(p2, r);
                viewMapControler1.Context.Map.CreateHen(line, column, viewMapControler1.Context.Map);
            }
        }
    }
}
