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
    }
}
