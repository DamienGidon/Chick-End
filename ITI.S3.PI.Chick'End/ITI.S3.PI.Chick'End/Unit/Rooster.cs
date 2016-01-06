using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Rooster : Tower
    {
        internal Rooster( Square context)
            : base( context, 1500 )
        {
            _attackSpeed = 20 * 60;
            _health = 50;
            _kind = "hen";
            _passivImage = Image.FromFile("Rooster.png");
            _attackImage = Image.FromFile("Rooster.png");
            _image = _passivImage;
        }

       
        public override void Attack(Unit ennemi, int tick)
        {
            if (tick % _attackSpeed == 0)
            {
                foreach(Ennemi e in Square.Context.Ennemis)
                    ennemi.Health -= Damages;
            }
        }

        public override List<Square> ComputeRange()
        {
            List<Square> list = new List<Square>();
            for( int i = 0; i < FinalVariables.NbCaseHeightMap1; i++)
            {
                for( int j = 0; j < FinalVariables.NbCaseWidthMap1; j++)
                {
                    if (Square.Context.Square[i, j].Decoration == "path")
                    {
                        list.Add(Square.Context.Square[i, j]);
                    }
                }
            }
            return list;
        }

        public override void CreateTower( int line, int column, Map map )
        {
            throw new NotImplementedException();
        }

        /*
        public override void Remove()
        {

        }
        */
    }
}
