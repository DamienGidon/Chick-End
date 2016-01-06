using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Bucher : Tower
    {

        Random r = new Random();

        internal Bucher(Square context)
            : base( context, 15 )
        {
            _attackSpeed = 100;
            _health = 400;
            _kind = "human";
            _passivImage = Image.FromFile("Butcher.png");
            _attackImage = Image.FromFile("ButcherSummon.png");
            _image = _passivImage;
        }

        public override void Attack(Unit ennemi, int tick)
        {
            
        }

        public void Summon(int tick)
        {
            Square square;
            if (tick % _attackSpeed == 0)
            {
                do
                {
                    square = _range[ r.Next( 0, _range.Count() ) ];
                } while (square.Tower != null);
                Context.Context.CreateSteak(Square.Context, square.Line, square.Column);
            }
        }

        /*
        public override void Remove()
        {

        }
        */
    }
}
