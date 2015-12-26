using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Baker : Tower
    {
        internal Baker(Square context)
            : base( context, 0 )
        {
            _health = 500;
            _kind = "human";
            _image = Image.FromFile("Baker.png");
        }

        public override void Attack(Unit ennemi, int tick)
        {
            
        }

        //public override List<Square> GetRange()
        //{
        //    throw new NotImplementedException();
        //}

        /*
        public override void Remove()
        {

        }
        */
    }
}
