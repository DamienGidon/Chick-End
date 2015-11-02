using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public class Map
    {
        Square[,] _squares;

        // Contructor
        internal Map()
        {
            Square[,] _squares = new Square[8,13];

            // Setting the hen house
            for( int i = 3; i < 6; i++)
            {
                _squares[i, 0] = null; // Poulailler à l'avenir ?
            }
            // Setting the other decorations
            for( int i = 0; i < 9; i++)
            {
                // Setting the trees
                if( i < 3 || i > 5)
                {
                    for( int j = 0; j < 14; j++)
                    {
                        _squares[i, j] = new Square( "tree" );
                    }
                }
                else if( i == 4)
                {
                    for( int j = 1; j < 14; j++)
                    {
                        _squares[i, j] = new Square( "tree" );
                    }
                }
                // Setting the paths
                if( i == 3 || i == 5)
                {
                    for( int j = 1; j < 14; j++)
                    {
                        _squares[i, j] = new Square( "path" );
                    }
                }
            }
        }
    }
}
