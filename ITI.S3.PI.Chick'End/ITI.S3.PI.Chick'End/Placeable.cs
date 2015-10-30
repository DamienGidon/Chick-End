using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    abstract class Placeable : Unit, IRemove
    {
        public virtual void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
