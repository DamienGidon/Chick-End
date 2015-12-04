using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public static class FinalVariables
    {
        public static readonly int NbCaseWidth = 14;
        public static readonly int NbCaseHeight = 9;

        public static int SquareWidthInMeters = 50;
        public static int SquareHeightInMeters = 50;

        public static int MapWidthInMeters = SquareWidthInMeters * NbCaseWidth;
        public static int MapHeightInMeters = SquareHeightInMeters * NbCaseHeight;
    }
}
