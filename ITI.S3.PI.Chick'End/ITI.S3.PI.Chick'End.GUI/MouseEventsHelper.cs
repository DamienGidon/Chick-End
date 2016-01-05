using System.Drawing;
using System.Windows.Forms;

namespace ITI.S3.PI.Chick_End.GUI
{
    public static class MouseEventsHelper
    {
        public static void ChangeFont_MouseEnter( object sender )
        {
            Button b = (Button)sender;
            b.Font = new Font( "Playbill", 28F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            b.FlatAppearance.MouseOverBackColor = Color.Transparent;
            b.Refresh();
        }
        public static void ChangeFont_MouseLeave( object sender )
        {
            Button b = (Button)sender;
            b.Font = new Font( "Playbill", 25F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            b.Refresh();
        }

        public static void DragDrop_UnitPicturebox( object sender, DragEventArgs e )
        {
            PictureBox pb = ((PictureBox)sender);
            pb.Image = (Image)e.Data.GetData( DataFormats.Bitmap );
        }

        public static void MouseDown_UnitPicturebox( this gamecontrol g, object sender, MouseEventArgs e, ViewMapControler v )
        {
            PictureBox pb = ((PictureBox)sender);
            pb.Select();
            pb.DoDragDrop( pb.Image, DragDropEffects.Copy );

            var relativePoint = v.PointToClient( Cursor.Position = new Point( Cursor.Position.X, Cursor.Position.Y ) );
            int topLeftCornerX = ((relativePoint.X / (v.Width / v.Map.NbCaseWidth)) * (v.Width / v.Map.NbCaseWidth));
            int topLeftCornerY = ((relativePoint.Y / (v.Height / v.Map.NbCaseHeight)) * (v.Height / v.Map.NbCaseHeight));
            int line = topLeftCornerY / (v.Height / v.Map.NbCaseHeight);
            int column = topLeftCornerX / (v.Width / v.Map.NbCaseWidth);

            if (v.Map.Square[line, column].Decoration != "path" || v.Map.Square[line, column].Tower != null)
            {

            }
            else
            {
                if (g.HenCreater.HenCost <= g.Seeds)
                {
                    g.Seeds -= g.HenCreater.HenCost;
                    // v.Map.CreateTower( line, column, v.Map );
                    // viewMapControler1.Context.HenCreater.CreateHen(line, column, viewMapControler1.Context.Map);
                }
            }
        }
    }
}
