using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public class Map
    {
        readonly Square[,] _squares;
        //readonly Dictionary<string, Tower> _towers;
        //readonly Dictionary<string, Ennemi> _ennemis;

        List<Unit> AllUnits
        {
            get
            {
                List<Unit> units = new List<Unit>();
                //foreach (Tower tower in _towers.Values) units.Add(tower);
                //foreach (Ennemi ennemi in _ennemis.Values) units.Add(ennemi);

                return units;
            }
        }

        public Tower CreateHen(Map context)
        {
            Square[0, 0].Tower = new Hen();
            return Square[0, 0].Tower;
        }
        

        /*
         * Constructor
         */
        public Map()
        {
            _squares = new Square[ FinalVariables._nbCaseHeight, FinalVariables._nbCaseWidth];

            // Setting the hen house
            for( int i = 3; i < 6; i++)
            {
                int j = 0;
                _squares[i, j] = new Square(this, i, j, "hen home" );
            }
            // Setting the other decorations
            for( int i = 0; i < 9; i++)
            {
                // Setting the trees
                if( i < 3 || i > 5)
                {
                    for( int j = 0; j < FinalVariables._nbCaseWidth; j++)
                    {
                        _squares[i, j] = new Square( this, i, j, "grass" );
                    }
                }
                else if( i == 4)
                {
                    for( int j = 1; j < FinalVariables._nbCaseWidth; j++)
                    {
                        _squares[i, j] = new Square( this, i, j, "grass" );
                    }
                }
                // Setting the paths
                else if( i == 3 || i == 5)
                {
                    for( int j = 1; j < FinalVariables._nbCaseWidth; j++)
                    {
                        _squares[i, j] = new Square( this, i, j, "path" );
                    }
                }
            }
        }

        public Square[,] Square
        {
            get { return _squares; }
        }

        public Square this[int ligne, int colonne]
        {
            get { return _squares[ligne, colonne]; }
        }
    }
}