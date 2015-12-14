using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End.GUI
{
    public interface IGameContext
    {
        Game CurrentGame { get; set; }

        event EventHandler CurrentGameChanged;
    }
}
