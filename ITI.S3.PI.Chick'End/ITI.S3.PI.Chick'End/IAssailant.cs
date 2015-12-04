using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public interface IAssailant
    {
        IReadOnlyList<Square> Range { get; }

        List<Square> ComputeRange();
        void Attack(Unit ennemi);
    }
}
