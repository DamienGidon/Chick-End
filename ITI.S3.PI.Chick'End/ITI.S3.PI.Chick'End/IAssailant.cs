using System.Collections.Generic;

namespace ITI.S3.PI.Chick_End
{
    public interface IAssailant
    {
        IReadOnlyList<Square> Range { get; }

        List<Square> ComputeRange();
        void Attack(Unit enemy, int tick);
    }
}
