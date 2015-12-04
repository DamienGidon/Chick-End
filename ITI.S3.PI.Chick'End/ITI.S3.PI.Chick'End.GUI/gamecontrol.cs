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
using System.Runtime.Serialization.Formatters.Binary;

namespace ITI.S3.PI.Chick_End.GUI
{
    public partial class gamecontrol : UserControl
    {
        Panel _panel;

        int _squareHeight;
        int _squareWidth;

        public gamecontrol(Panel panel)
        {
            InitializeComponent();

            _panel = panel;

            _squareHeight = this.viewMapControler1.Height / 9;
            _squareWidth = this.viewMapControler1.Width / 14;

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

            Bitmap p6 = new Bitmap(@"Baker.png");
            Graphics g6 = Graphics.FromImage(p);
            g6.DrawImage(p6, 60, 60);
            pictureBox6.Image = p6;

            Bitmap p7 = new Bitmap(@"ExplosiveEgg.png");
            Graphics g7 = Graphics.FromImage(p);
            g7.DrawImage(p7, 60, 60);
            pictureBox7.Image = p7;

            Bitmap p8 = new Bitmap(@"Bucher.png");
            Graphics g8 = Graphics.FromImage(p);
            g8.DrawImage(p8, 60, 60);
            pictureBox8.Image = p8;

            Bitmap p9 = new Bitmap(@"Rooster.png");
            Graphics g9 = Graphics.FromImage(p);
            g8.DrawImage(p9, 60, 60);
            pictureBox9.Image = p9;

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
            pictureBox6.DragDrop += new DragEventHandler(pictureBox6_DragDrop);
            pictureBox6.MouseDown += new MouseEventHandler(pictureBox6_MouseDown);
            pictureBox7.DragDrop += new DragEventHandler(pictureBox7_DragDrop);
            pictureBox7.MouseDown += new MouseEventHandler(pictureBox7_MouseDown);
            pictureBox8.DragDrop += new DragEventHandler(pictureBox8_DragDrop);
            pictureBox8.MouseDown += new MouseEventHandler(pictureBox8_MouseDown);
            viewMapControler1.DragDrop += new DragEventHandler(viewMapControler1_DragDrop);
            //viewMapControler1.MouseDown += new MouseEventHandler(viewMapControler1_MouseDown);
            pictureBox9.DragDrop += new DragEventHandler(pictureBox9_DragDrop);
            pictureBox9.MouseDown += new MouseEventHandler(pictureBox9_MouseDown);

            viewMapControler1.DragEnter += new DragEventHandler( viewMapControler1_DragEnter );
            panel1.DragEnter += new DragEventHandler( viewMapControler1_DragEnter );

            pictureBox1.AllowDrop = false;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;
            pictureBox7.AllowDrop = true;
            pictureBox8.AllowDrop = true;
            pictureBox9.AllowDrop = true;

            viewMapControler1.AllowDrop = true;
            panel1.AllowDrop = true;
        }



        private void ManageUsersControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
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
        private void buttonBestiary_Click(object sender, EventArgs e)
        {
            Bestiary b = new Bestiary();
            b.ShowDialog();
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

        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            buttonSave.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonSave.Refresh();
        }

        private void buttonSave_MouseLeave(object sender, EventArgs e)
        {
            buttonSave.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonSave.Refresh();
        }

        private void buttonQuit_MouseEnter(object sender, EventArgs e)
        {
            buttonQuit.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonQuit.Refresh();
        }

        private void buttonQuit_MouseLeave(object sender, EventArgs e)
        {
            buttonQuit.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonQuit.Refresh();
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
            int topLeftCornerX = ((relativePoint.X / _squareWidth) * _squareWidth);
            int topLeftCornerY = ((relativePoint.Y / _squareHeight) * _squareHeight);
            int line = topLeftCornerY / _squareHeight;
            int column = topLeftCornerX / _squareWidth;
            

            if (viewMapControler1.Context.Map.Square[line, column].Decoration != "path" || viewMapControler1.Context.Map.Square[line, column].Tower != null)
            {
                
            }
            else
            {

                Bitmap p2 = new Bitmap(@"HenLeft.png");
                Graphics g = Graphics.FromImage(p2);
                
                Rectangle r = new Rectangle(topLeftCornerX, topLeftCornerY, _squareWidth, _squareHeight);
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
            int topLeftCornerX = ((relativePoint.X / _squareWidth) * _squareWidth);
            int topLeftCornerY = ((relativePoint.Y / _squareHeight) * _squareHeight);
            int line = topLeftCornerY / _squareHeight;
            int column = topLeftCornerX / _squareWidth;

            if (viewMapControler1.Context.Map.Square[line, column].Decoration != "path" || viewMapControler1.Context.Map.Square[line, column].Tower != null)
            {
                
            }
            else
            {

                Bitmap p2 = new Bitmap(@"InfantryFarmer.png");
                Graphics g2 = Graphics.FromImage(p2);

                Rectangle r2 = new Rectangle(topLeftCornerX, topLeftCornerY-20, _squareWidth, _squareHeight + 20);
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
            int topLeftCornerX = ((relativePoint.X / _squareWidth) * _squareWidth);
            int topLeftCornerY = ((relativePoint.Y / _squareHeight) * _squareHeight);
            int line = topLeftCornerY / _squareHeight;
            int column = topLeftCornerX / _squareWidth;

            if (viewMapControler1.Context.Map.Square[line, column].Decoration != "path" || viewMapControler1.Context.Map.Square[line, column].Tower != null)
            {
                
            }
            else
            {

                Bitmap p4 = new Bitmap(@"GunnerFarmer.png");
                Graphics g4 = Graphics.FromImage(p4);

                Rectangle r4 = new Rectangle(topLeftCornerX, topLeftCornerY - 20, _squareWidth, _squareHeight+20);
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
            int topLeftCornerX = ((relativePoint.X / _squareWidth) * _squareWidth);
            int topLeftCornerY = ((relativePoint.Y / _squareHeight) * _squareHeight);
            int line = topLeftCornerY / _squareHeight;
            int column = topLeftCornerX / _squareWidth;

            if (viewMapControler1.Context.Map.Square[line, column].Decoration != "path" || viewMapControler1.Context.Map.Square[line, column].Tower != null)
            {
                
            }
            else
            {
               
                Bitmap p3 = new Bitmap(@"bomberHen.png");
                Graphics g3 = Graphics.FromImage(p3);

                Rectangle r3 = new Rectangle(topLeftCornerX, topLeftCornerY, _squareWidth, _squareHeight);
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
            int topLeftCornerX = ((relativePoint.X / _squareWidth) * _squareWidth);
            int topLeftCornerY = ((relativePoint.Y / _squareHeight) * _squareHeight);
            int line = topLeftCornerY / _squareHeight;
            int column = topLeftCornerX / _squareWidth;

            if (viewMapControler1.Context.Map.Square[line, column].Decoration != "path" || viewMapControler1.Context.Map.Square[line, column].Tower != null)
            {
                
            }
            else
            {

                Bitmap p5 = new Bitmap(@"OldHen.png");
                Graphics g5 = Graphics.FromImage(p5);

                Rectangle r5 = new Rectangle(topLeftCornerX, topLeftCornerY - 0, _squareWidth, _squareHeight);
                PaintEventArgs e1 = new PaintEventArgs(viewMapControler1.CreateGraphics(), r5);
                e1.Graphics.DrawImage(p5, r5);
                viewMapControler1.Context.Map.CreateOldHen(line, column, viewMapControler1.Context.Map);

            }
        }

        private void pictureBox6_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb6 = ((PictureBox)sender);
            pb6.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb6 = ((PictureBox)sender);
            pb6.Select();
            pb6.DoDragDrop(pb6.Image, DragDropEffects.Copy);

            var relativePoint = viewMapControler1.PointToClient(Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y));
            int topLeftCornerX = ((relativePoint.X / _squareWidth) * _squareWidth);
            int topLeftCornerY = ((relativePoint.Y / _squareHeight) * _squareHeight);
            int line = topLeftCornerY / _squareHeight;
            int column = topLeftCornerX / _squareWidth;

            if (viewMapControler1.Context.Map.Square[line, column].Decoration != "path" || viewMapControler1.Context.Map.Square[line, column].Tower != null)
            {

            }
            else
            {

                Bitmap p6 = new Bitmap(@"Baker.png");
                Graphics g6 = Graphics.FromImage(p6);

                Rectangle r6 = new Rectangle(topLeftCornerX, topLeftCornerY - 20, _squareWidth, _squareHeight + 20);
                PaintEventArgs e1 = new PaintEventArgs(viewMapControler1.CreateGraphics(), r6);
                e1.Graphics.DrawImage(p6, r6);
                viewMapControler1.Context.Map.CreateBaker(line, column, viewMapControler1.Context.Map);
            }
        }

        private void pictureBox7_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb7 = ((PictureBox)sender);
            pb7.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb7 = ((PictureBox)sender);
            pb7.Select();
            pb7.DoDragDrop(pb7.Image, DragDropEffects.Copy);

            var relativePoint = viewMapControler1.PointToClient(Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y));
            int topLeftCornerX = ((relativePoint.X / _squareWidth) * _squareWidth);
            int topLeftCornerY = ((relativePoint.Y / _squareHeight) * _squareHeight);
            int line = topLeftCornerY / _squareHeight;
            int column = topLeftCornerX / _squareWidth;

            if (viewMapControler1.Context.Map.Square[line, column].Decoration != "path" || viewMapControler1.Context.Map.Square[line, column].Tower != null)
            {

            }
            else
            {

                Bitmap p7 = new Bitmap(@"ExplosiveEgg.png");
                Graphics g7 = Graphics.FromImage(p7);

                Rectangle r7 = new Rectangle(topLeftCornerX + 8, topLeftCornerY + 5, _squareWidth - 20, _squareHeight - 10);
                PaintEventArgs e1 = new PaintEventArgs(viewMapControler1.CreateGraphics(), r7);
                e1.Graphics.DrawImage(p7, r7);
                viewMapControler1.Context.Map.CreateExplosiveEgg(line, column, viewMapControler1.Context.Map);
            }
        }

        private void pictureBox8_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb8 = ((PictureBox)sender);
            pb8.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb8 = ((PictureBox)sender);
            pb8.Select();
            pb8.DoDragDrop(pb8.Image, DragDropEffects.Copy);

            var relativePoint = viewMapControler1.PointToClient(Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y));
            int topLeftCornerX = ((relativePoint.X / _squareWidth) * _squareWidth);
            int topLeftCornerY = ((relativePoint.Y / _squareHeight) * _squareHeight);
            int line = topLeftCornerY / _squareHeight;
            int column = topLeftCornerX / _squareWidth;

            if (viewMapControler1.Context.Map.Square[line, column].Decoration != "path" || viewMapControler1.Context.Map.Square[line, column].Tower != null)
            {

            }
            else
            {

                Bitmap p8 = new Bitmap(@"Bucher.png");
                Graphics g8 = Graphics.FromImage(p8);

                Rectangle r8 = new Rectangle(topLeftCornerX, topLeftCornerY - 20, _squareWidth, _squareHeight + 20);
                PaintEventArgs e1 = new PaintEventArgs(viewMapControler1.CreateGraphics(), r8);
                e1.Graphics.DrawImage(p8, r8);
                viewMapControler1.Context.Map.CreateBucher(line, column, viewMapControler1.Context.Map);
            }
        }
        private void pictureBox9_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb9 = ((PictureBox)sender);
            pb9.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb9 = ((PictureBox)sender);
            pb9.Select();
            pb9.DoDragDrop(pb9.Image, DragDropEffects.Copy);

            var relativePoint = viewMapControler1.PointToClient(Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y));
            int topLeftCornerX = ((relativePoint.X / _squareWidth) * _squareWidth);
            int topLeftCornerY = ((relativePoint.Y / _squareHeight) * _squareHeight);
            int line = topLeftCornerY / _squareHeight;
            int column = topLeftCornerX / _squareWidth;

            if (viewMapControler1.Context.Map.Square[line, column].Decoration != "path" || viewMapControler1.Context.Map.Square[line, column].Tower != null)
            {

            }
            else
            {

                Bitmap p9 = new Bitmap(@"Rooster.png");
                Graphics g9 = Graphics.FromImage(p9);

                Rectangle r9 = new Rectangle(topLeftCornerX, topLeftCornerY - 5, _squareWidth, _squareHeight+5);
                PaintEventArgs e1 = new PaintEventArgs(viewMapControler1.CreateGraphics(), r9);
                e1.Graphics.DrawImage(p9, r9);
                viewMapControler1.Context.Map.CreateRooster(line, column, viewMapControler1.Context.Map);
            }
        }
        private void viewMapControler1_DragDrop(object sender, DragEventArgs e)
        {
            ViewMapControler v = ((ViewMapControler)sender);
            var relativePoint = viewMapControler1.PointToClient(Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y));
        }

        //private void viewMapControler1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ViewMapControler v = ((ViewMapControler)sender);
        //    v.Select();
        //    v.DoDragDrop(v, DragDropEffects.Copy);
        //    //MessageBox.Show("E.X est égal à : " + e.X);
        //    var relativePoint = viewMapControler1.PointToClient(Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y));
        //    int line = e.X / 50;
        //    int column = e.Y / 50;

        //    if (viewMapControler1.Context.Map.Square[line, column].Tower != null)


        //    {
        //        viewMapControler1.Context.Map.Square[line, column].Tower = null;
        //        Rectangle r = new Rectangle(line, column, 50, 70);
        //        PaintEventArgs e1 = new PaintEventArgs(viewMapControler1.CreateGraphics(), r);
        //        e1.Graphics.Clear(Color.Teal);

        //    }
        //}

        private void viewMapControler1_Click(object sender, EventArgs e)
        {

            var relativePoint = viewMapControler1.PointToClient(Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y));
            int topLeftCornerX = ((relativePoint.X / _squareWidth) * _squareWidth);
            int topLeftCornerY = ((relativePoint.Y / _squareHeight) * _squareHeight);
            int line = topLeftCornerY / _squareHeight;
            int column = topLeftCornerX / _squareWidth;

            Bitmap p9 = new Bitmap(@"Wolf.png");
            Graphics g9 = Graphics.FromImage(p9);

            Random r = new Random();
            int r2 = r.Next(1,3);

            if (r2 == 1)
            {
                Rectangle r9 = new Rectangle(_squareWidth * 13, _squareHeight * 3 , _squareWidth, _squareHeight + 20);
                PaintEventArgs e1 = new PaintEventArgs(viewMapControler1.CreateGraphics(), r9);
                e1.Graphics.DrawImage(p9, r9);
                viewMapControler1.Context.Map.CreateWolf(line, column, viewMapControler1.Context.Map);
            }
            else
            {
                Rectangle r9 = new Rectangle(_squareWidth * 13, _squareHeight * 5, _squareWidth, _squareHeight + 20);
                PaintEventArgs e1 = new PaintEventArgs(viewMapControler1.CreateGraphics(), r9);
                e1.Graphics.DrawImage(p9, r9);
                viewMapControler1.Context.Map.CreateWolf(line, column, viewMapControler1.Context.Map);
            }
        }

        private void viewMapControler1_Resize(object sender, EventArgs e)
        {
            ViewMapControler item = (ViewMapControler)sender;
            //List<Tower> _tower = viewMapControler1.Context.Map.GetTower;
            item.Refresh();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("objet.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                BinaryFormatter ser = new BinaryFormatter();
                ser.Serialize(fs, viewMapControler1.Context);
            }
        }
    }
}
