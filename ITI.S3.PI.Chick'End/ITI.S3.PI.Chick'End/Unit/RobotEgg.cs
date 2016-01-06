using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class RobotEgg : EggLauncher
    {

        public RobotEgg(Map context, int damage, int x, int y)
            : base(context, damage, x, y)
        {
            _image = Image.FromFile("RobotEgg.png");
            _imageWidth = 26;
            _imageHeight = 20;
        }

        public override void Attack(Unit ennemi, int tick)
        {
            foreach (Ennemi e in Square.Context.Ennemis)
            {
                if ((e.Square == ennemi.Square)
                    || ((e.Square.Line == ennemi.Square.Line) && (e.Square.Column == ennemi.Square.Column + 1))
                    || ((e.Square.Line == ennemi.Square.Line + 1) && (e.Square.Column == ennemi.Square.Column))
                    || ((e.Square.Line == ennemi.Square.Line - 1) && (e.Square.Column == ennemi.Square.Column)))
                {
                    e.Health -= Damages;
                }
            }
        }
    }
}
