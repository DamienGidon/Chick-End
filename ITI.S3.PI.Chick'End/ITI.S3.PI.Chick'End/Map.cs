using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public class Map
    {
        readonly List<Way> _ways;
        readonly Square[,] _squares;
        readonly List<Ennemi> _ennemis;
        readonly List<Tower> _towers;

        List<Unit> AllUnits
        {
            get
            {
                List<Unit> units = new List<Unit>();
                return units;
            }
        }

        public List<Tower> Towers
        {
            get { return _towers; }
        }

        public List<Ennemi> Ennemis
        {
            get { return _ennemis; }
        }
        
        /*
        * Constructor
        */
        public Map()
        {
            _squares = new Square[ FinalVariables._nbCaseHeight, FinalVariables._nbCaseWidth];
            _ways = new List<Way>();
            _towers  = new List<Tower>();
            _ennemis = new List<Ennemi>();

            // Setting the hen house
            for ( int i = 3; i < 6; i++)
            {
                int j = 0;
                _squares[i, j] = new Square(this, i, j, "HomeHen" );
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

            /*
            * chaining of the squares
            */ 
            for( int i = 13; i > 0; i--)
            {
                _squares[3, i].NextSquare = _squares[3, i - 1];
            }
            for (int i = 13; i > 0; i--)
            {
                _squares[5, i].NextSquare = _squares[3, i - 1];
            }

            /*
            * Creation of the different ways
            */
            Way w1 = new Way( _squares[3, 13] );
            Way w2 = new Way( _squares[5, 13] );

            _ways.Add( w1 );
            _ways.Add( w2 );
        }

        internal List<Way> Ways
        {
            get { return _ways; }
        }
        public Square[,] Square
        {
            get { return _squares; }
        }

        public Square this[int ligne, int colonne]
        {
            get { return _squares[ligne, colonne]; }
        }

        public void CreateHen( int ligne, int colonne, Map context )
        {
            Tower t = new Hen(context._squares[ligne, colonne]);
            Square[ligne, colonne].Tower = t;
            _towers.Add( t );
        }
        public void CreateOldHen( int ligne, int colonne, Map context )
        {
            Tower t = new OldHen( context._squares[ligne, colonne] );
            Square[ligne, colonne].Tower = t;
            _towers.Add( t );
        }
        public void CreateBomberHen( int ligne, int colonne, Map context )
        {
            Tower t = new BomberHen( context._squares[ligne, colonne] );
            Square[ligne, colonne].Tower = t;
            _towers.Add( t );
        }
        public void CreateRooster( int ligne, int colonne, Map context )
        {
            Tower t = new Rooster( context._squares[ligne, colonne] );
            Square[ligne, colonne].Tower = t;
            _towers.Add( t );
        }
        public void CreateBaker( int ligne, int colonne, Map context )
        {
            Tower t = new Baker( context._squares[ligne, colonne] );
            Square[ligne, colonne].Tower = t;
            _towers.Add( t );
        }
        public void CreateExplosiveEgg( int ligne, int colonne, Map context )
        {
            Tower t = new ExplosiveEgg();
            Square[ligne, colonne].Tower = t;
            _towers.Add( t );
        }
        public void CreateBucher( int ligne, int colonne, Map context )
        {
            Tower t = new Bucher( context._squares[ligne, colonne] );
            Square[ligne, colonne].Tower = t;
            _towers.Add( t );
        }
        public void CreateInfantryFarmer( int ligne, int colonne, Map context )
        {
            Tower t = new InfantryFarmer( context._squares[ligne, colonne] );
            Square[ligne, colonne].Tower = t;
            _towers.Add( t );
        }
        public void CreateGunnerFarmer( int ligne, int colonne, Map context )
        {
            Tower t = new GunnerFarmer( context._squares[ligne, colonne] );
            Square[ligne, colonne].Tower = t;
            _towers.Add( t );
        }        

        public void CreateWolf( int ligne, int colonne, Map context)
        {
            Ennemi e = new Wolf(context);
            Square[ligne, colonne].Ennemi = e;
            _ennemis.Add(e);
        }

        public void CreateHyena(int ligne, int colonne, Map context)
        {
            Ennemi e = new Hyena();
            Square[ligne, colonne].Ennemi = e;
            _ennemis.Add(e);
        }

        public void CreateFox(int ligne, int colonne, Map context)
        {
            Ennemi e = new Fox();
            Square[ligne, colonne].Ennemi = e;
            _ennemis.Add(e);
        }

        public void CreateLion(int ligne, int colonne, Map context)
        {
            Ennemi e = new Lion();
            Square[ligne, colonne].Ennemi = e;
            _ennemis.Add(e);
        }

        public void CreateAnubis(int ligne, int colonne, Map context)
        {
            Ennemi e = new Anubis();
            Square[ligne, colonne].Ennemi = e;
            _ennemis.Add(e);
        }

        public void CreateCerberus(int ligne, int colonne, Map context)
        {
            Ennemi e = new Cerberus();
            Square[ligne, colonne].Ennemi = e;
            _ennemis.Add(e);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}