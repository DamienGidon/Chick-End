using System;
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
            //viewMapControler1.Context.Stopwatch.Start();
            Bitmap p = new Bitmap(@"HenLeft.png");
            Graphics g = Graphics.FromImage(p);
            g.DrawImage(p, 60, 60);
            pictureBox1.Image = p;

            Bitmap p2 = new Bitmap(@"InfantryFarmer.png");
            Graphics g2 = Graphics.FromImage(p);
            g2.DrawImage(p2, 60, 60);
            pictureBox2.Image = p2;

            Bitmap p3 = new Bitmap(@"bomberHen.png");
            Graphics g3 = Graphics.FromImage(p);
            g3.DrawImage(p3, 60, 60);
            pictureBox3.Image = p3;

            Bitmap p4 = new Bitmap(@"GunnerFarmer.png");
            Graphics g4 = Graphics.FromImage(p);
            g4.DrawImage(p4, 60, 60);
            pictureBox4.Image = p4;

            Bitmap p5 = new Bitmap(@"OldHen.png");
            Graphics g5 = Graphics.FromImage(p);
            g5.DrawImage(p5, 60, 60);
            pictureBox5.Image = p5;

            pictureBox1.DragDrop += new DragEventHandler(pictureBox1_DragDrop);
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox2.DragDrop += new DragEventHandler(pictureBox2_DragDrop);
            pictureBox2.MouseDown += new MouseEventHandler(pictureBox2_MouseDown);
            pictureBox3.DragDrop += new DragEventHandler(pictureBox3_DragDrop);
            pictureBox3.MouseDown += new MouseEventHandler(pictureBox3_MouseDown);
            pictureBox4.DragDrop += new DragEventHandler(pictureBox4_DragDrop);
            pictureBox4.MouseDown += new MouseEventHandler(pictureBox4_MouseDown);
            pictureBox5.DragDrop += new DragEventHandler(pictureBox5_DragDrop);
            pictureBox5.MouseDown += new MouseEventHandler(pictureBox5_MouseDown);

            viewMapControler1.DragEnter += new DragEventHandler( viewMapControler1_DragEnter );
            panel1.DragEnter += new DragEventHandler( viewMapControler1_DragEnter );

            pictureBox1.AllowDrop = false;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
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

            //pb.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        
        private void viewMapControler1_DragEnter( object sender, DragEventArgs e )
        {
            if (e.Data.GetDataPresent( DataFormats.Bitmap ))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = ((PictureBox)sender);
            pb.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
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

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb2 = ((PictureBox)sender);
            pb2.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb2 = ((PictureBox)sender);
            pb2.Select();
            pb2.DoDragDrop(pb2.Image, DragDropEffects.Copy);

            var relativePoint = viewMapControler1.PointToClient(Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y));
            int topLeftCornerX = ((relativePoint.X / 50) * 50);
            int topLeftCornerY = ((relativePoint.Y / 50) * 50);
            int line = topLeftCornerY / 50;
            int column = topLeftCornerX / 50;

            if (viewMapControler1.Context.Map.Square[line, column].Decoration != "path" || viewMapControler1.Context.Map.Square[line, column].Tower != null)
            {
                
            }
            else
            {

                Bitmap p2 = new Bitmap(@"InfantryFarmer.png");
                Graphics g2 = Graphics.FromImage(p2);

                Rectangle r2 = new Rectangle(topLeftCornerX, topLeftCornerY-20, 50, 70);
                PaintEventArgs e1 = new PaintEventArgs(viewMapControler1.CreateGraphics(), r2);
                e1.Graphics.DrawImage(p2, r2);
                viewMapControler1.Context.Map.CreateInfantryFarmer(line, column, viewMapControler1.Context.Map);
            }
        }

        private void pictureBox3_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb3 = ((PictureBox)sender);
            pb3.Image = (Image)e.Data.GetData(DataFormats.Bitmap);


        }
        private void pictureBox4_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb4 = ((PictureBox)sender);
            pb4.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
         
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb4 = ((PictureBox)sender);
            pb4.Select();
            pb4.DoDragDrop(pb4.Image, DragDropEffects.Copy);

            var relativePoint = viewMapControler1.PointToClient(Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y));
            int topLeftCornerX = ((relativePoint.X / 50) * 50);
            int topLeftCornerY = ((relativePoint.Y / 50) * 50);
            int line = topLeftCornerY / 50;
            int column = topLeftCornerX / 50;

            if (viewMapControler1.Context.Map.Square[line, column].Decoration != "path" || viewMapControler1.Context.Map.Square[line, column].Tower != null)
            {
                
            }
            else
            {

                Bitmap p4 = new Bitmap(@"GunnerFarmer.png");
                Graphics g4 = Graphics.FromImage(p4);

                Rectangle r4 = new Rectangle(topLeftCornerX, topLeftCornerY - 20, 50, 70);
                PaintEventArgs e1 = new PaintEventArgs(viewMapControler1.CreateGraphics(), r4);
                e1.Graphics.DrawImage(p4, r4);
                viewMapControler1.Context.Map.CreateGunnerFarmer(line, column, viewMapControler1.Context.Map);
              
            }
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb3 = ((PictureBox)sender);
            pb3.Select();
            pb3.DoDragDrop(pb3.Image, DragDropEffects.Copy);

            var relativePoint = viewMapControler1.PointToClient(Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y));
            int topLeftCornerX = ((relativePoint.X / 50) * 50);
            int topLeftCornerY = ((relativePoint.Y / 50) * 50);
            int line = topLeftCornerY / 50;
            int column = topLeftCornerX / 50;

            if (viewMapControler1.Context.Map.Square[line, column].Decoration != "path" || viewMapControler1.Context.Map.Square[line, column].Tower != null)
            {
                
            }
            else
            {
               
                Bitmap p3 = new Bitmap(@"bomberHen.png");
                Graphics g3 = Graphics.FromImage(p3);

                Rectangle r3 = new Rectangle(topLeftCornerX, topLeftCornerY, 50, 50);
                PaintEventArgs e1 = new PaintEventArgs(viewMapControler1.CreateGraphics(), r3);
                e1.Graphics.DrawImage(p3, r3);
                viewMapControler1.Context.Map.CreateBomberHen(line, column, viewMapControler1.Context.Map);
            }
        }

        private void pictureBox5_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb4 = ((PictureBox)sender);
            pb4.Image = (Image)e.Data.GetData(DataFormats.Bitmap);

        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb5 = ((PictureBox)sender);
            pb5.Select();
            pb5.DoDragDrop(pb5.Image, DragDropEffects.Copy);

            var relativePoint = viewMapControler1.PointToClient(Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y));
            int topLeftCornerX = ((relativePoint.X / 50) * 50);
            int topLeftCornerY = ((relativePoint.Y / 50) * 50);
            int line = topLeftCornerY / 50;
            int column = topLeftCornerX / 50;

            if (viewMapControler1.Context.Map.Square[line, column].Decoration != "path" || viewMapControler1.Context.Map.Square[line, column].Tower != null)
            {
                
            }
            else
            {

                Bitmap p5 = new Bitmap(@"OldHen.png");
                Graphics g5 = Graphics.FromImage(p5);

                Rectangle r5 = new Rectangle(topLeftCornerX, topLeftCornerY - 0, 50, 50);
                PaintEventArgs e1 = new PaintEventArgs(viewMapControler1.CreateGraphics(), r5);
                e1.Graphics.DrawImage(p5, r5);
                viewMapControler1.Context.Map.CreateGunnerFarmer(line, column, viewMapControler1.Context.Map);

            }
        }
    }
}
