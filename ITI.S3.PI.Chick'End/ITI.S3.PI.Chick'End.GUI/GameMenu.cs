using System.Windows.Forms;

namespace ITI.S3.PI.Chick_End.GUI
{
    public partial class GameMenu : UserControl
    {
        Controler _controler;

        public GameMenu( Controler controler)
        {
            InitializeComponent();
            _controler = controler;
        }
    }
}
