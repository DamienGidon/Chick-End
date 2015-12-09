using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ITI.S3.PI.Chick_End.GUI
{
    class Animate
    {
        public Bitmap _animatedWolf = new Bitmap("WolfMove.gif");

        bool currentlyAnimating = false;
        private ViewMapControler viewMapControler;

        public Animate(ViewMapControler viewMapControler)
        {
            this.viewMapControler = viewMapControler;
        }

        public void AnimationWolf()
        {
            if (!currentlyAnimating)
            {
                currentlyAnimating = true;
                ImageAnimator.Animate(_animatedWolf, new EventHandler(this.OnFrameChanged));
                ImageAnimator.UpdateFrames();
            }
        }

        public Bitmap AnimatedWolf
        {
            get { return _animatedWolf; }
        }
        private void OnFrameChanged(object o, EventArgs e)
        {
            viewMapControler.Invalidate();
        }
    }
}
