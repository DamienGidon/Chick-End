using System.Drawing;
using System.Windows.Forms;

namespace ITI.S3.PI.Chick_End.GUI
{
    public static class MouseEventsHelper
    {
        public static void ChangeFontSize(object sender, float fontSize)
        {
            Button b = (Button)sender;
            b.Font = new Font("Playbill", fontSize, FontStyle.Regular, GraphicsUnit.Point, 0);
            b.FlatAppearance.MouseOverBackColor = Color.Transparent;
            b.Refresh();
        }
    }
}
