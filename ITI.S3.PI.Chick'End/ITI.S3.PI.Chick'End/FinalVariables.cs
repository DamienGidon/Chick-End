using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public static class FinalVariables
    {
        public static readonly int NbCaseWidthMap1 = 14;
        public static readonly int NbCaseHeightMap1 = 9;

        public static readonly int NbCaseWidthMap2 = 15;
        public static readonly int NbCaseHeightMap2 = 11;

        public static int SquareWidthInMeters = 50;
        public static int SquareHeightInMeters = 50;

        public static int MapWidthInMeters = SquareWidthInMeters * NbCaseWidthMap1;
        public static int MapHeightInMeters = SquareHeightInMeters * NbCaseHeightMap1;
    }
}
