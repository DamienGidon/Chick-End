using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Map
    {
        readonly List<Way> _ways;
        readonly Square[,] _squares;
        readonly List<Ennemi> _ennemis;
        readonly List<Tower> _towers;
        readonly List<EggLauncher> _eggs;
        readonly int _nbCaseWidth;
        readonly int _nbCaseHeight;

        List<Unit> AllUnits
        {
            get
            {
                List<Unit> AllUnits = new List<Unit>();
                foreach( Ennemi e in _ennemis)
                {
                    AllUnits.Add( e );
                }
                foreach( Tower t in _towers)
                {
                    AllUnits.Add( t );
                }
                return AllUnits;
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

        public List<EggLauncher> Eggs
        {
            get { return _eggs; }
        }

        public int NbCaseWidth
        {
            get { return _nbCaseWidth; }
        }
        public int NbCaseHeight
        {
            get { return _nbCaseHeight; }
        }

        /*
        * Constructor
        */
        public Map()
        {
            _nbCaseHeight = 9;
            _nbCaseWidth = 14;
            _squares = new Square[_nbCaseHeight, _nbCaseWidth];
            _ways = new List<Way>();
            _towers  = new List<Tower>();
            _ennemis = new List<Ennemi>();
            _eggs = new List<EggLauncher>();

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
                    for( int j = 0; j < _nbCaseWidth; j++)
                    {
                        _squares[i, j] = new Square( this, i, j, "grass" );
                    }
                }
                else if( i == 4)
                {
                    for( int j = 1; j < _nbCaseWidth; j++)
                    {
                        _squares[i, j] = new Square( this, i, j, "grass" );
                    }
                }
                // Setting the paths
                else if( i == 3 || i == 5)
                {
                    for( int j = 1; j < FinalVariables.NbCaseWidthMap1; j++)
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

        // Constructor of Map lvl 2
        public Map( string test )
        {
            _nbCaseHeight = 11;
            _nbCaseWidth = 15;
            _squares = new Square[_nbCaseHeight - 1, _nbCaseWidth - 1];
            _ways = new List<Way>();
            _towers = new List<Tower>();
            _ennemis = new List<Ennemi>();

            for ( int i = 0; i <= 3; i++)
            {
                _squares[i, 0] = new Square( this, i, 0, "grass" );
                _squares[i, 1] = new Square( this, i, 1, "grass" );
            }
            for (int i = 7; i < FinalVariables.NbCaseHeightMap2; i++)
            {
                _squares[i, 0] = new Square( this, i, 0, "grass" );
                _squares[i, 1] = new Square( this, i, 1, "grass" );
            }
            for (int i = 0; i < FinalVariables.NbCaseWidthMap2; i++)
            {
                _squares[4, i] = new Square( this, 4, i, "path" );
                _squares[6, i] = new Square( this, 6, i, "path" );
            }
            for( int i = 2; i<FinalVariables.NbCaseWidthMap2; i++)
            {
                _squares[0, i] = new Square( this, 0, i, "path" );
                _squares[0, i] = new Square( this, 10, i, "path" );
            }
            for (int i = 1; i < FinalVariables.NbCaseWidthMap2; i++)
            {
                _squares[5, i] = new Square( this, 5, i, "grass" );
            }
            for( int i = 1; i <= 5; i++ )
            {
                for( int j = 2; j < FinalVariables.NbCaseWidthMap2; j++ )
                {
                    _squares[i, j] = new Square( this, i, j, "grass" );
                }
            }
            for (int i = 7; i <= 9; i++)
            {
                for (int j = 2; j < FinalVariables.NbCaseWidthMap2; j++)
                {
                    _squares[i, j] = new Square( this, i, j, "grass" );
                }
            }

            // Chaining of the squares
            for( int i = _nbCaseWidth - 1; i > 2; i--)
            {
                _squares[0, i].NextSquare = _squares[0, i - 1];
            }
            for( int i = 0; i <= 3; i++)
            {
                _squares[i, 2].NextSquare = _squares[i - 1, 2];
            }
            for( int i= _nbCaseWidth - 1; i > 1; i--)
            {
                _squares[4, i].NextSquare = _squares[4, i - 1];
            }
            _squares[4, 0].NextSquare = _squares[5, 0];
            _squares[6, 0].NextSquare = _squares[5, 0];
            for( int i = _nbCaseWidth - 1; i > 2; i--)
            {
                _squares[_nbCaseHeight - 1, i].NextSquare = _squares[_nbCaseHeight - 1, i - 1];
            }
            for( int i = _nbCaseHeight - 1; i > 6; i-- )
            {
                _squares[i, 2].NextSquare = _squares[i, 2];
            }
            for( int i = _nbCaseWidth - 1; i > 1; i--)
            {
                _squares[6, i].NextSquare = _squares[6, i - 1];
            }

            // Creation of the ways
            Way w1 = new Way( _squares[0, _nbCaseWidth - 1] );
            Way w2 = new Way( _squares[4, _nbCaseWidth - 1] );
            Way w3 = new Way( _squares[6, _nbCaseWidth - 1] );
            Way w4 = new Way( _squares[_nbCaseHeight - 1, _nbCaseWidth - 1] );

            _ways.Add( w1 );
            _ways.Add( w2 );
            _ways.Add( w3 );
            _ways.Add( w4 );
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
            Tower t = new ExplosiveEgg(context[ligne, colonne]);
            Square[ligne, colonne].Tower = t;
            _towers.Add( t );
        }
        public void CreateButcher( int ligne, int colonne, Map context )
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

        public Wolf CreateWolf(Map context)
        {
            Wolf e = new Wolf(context, 20);
            _ennemis.Add(e);
            return e;
        }
        public Wolf CreateAnubisWolf(Map context, int x, int y)
        {
            Wolf e = new Wolf(context, 20);
            e.GetX = x;
            e.GetY = y;
            _ennemis.Add(e);
            return e;
        }

        public Hyena CreateHyena(Map context)
        {
            Hyena e = new Hyena(context, 30);
            _ennemis.Add(e);
            return e;
        }
        public Fox CreateFox(Map context)
        {
            Fox e = new Fox(context, 10);
            _ennemis.Add(e);
            return e;
        }
        public Lion CreateLion(Map context)
        {
            Lion e = new Lion(context, 15);
            _ennemis.Add(e);
            return e;
        }
        public Anubis CreateAnubis( Map context)
        {
            Anubis e = new Anubis(context, 50);
            _ennemis.Add(e);
            return e;
        }
        public Cerberus CreateCerberus(Map context)
        {
            Cerberus e = new Cerberus(context, 100);
            _ennemis.Add(e);
            return e;
        }

        public NormalEgg CreateNormalEgg(Map context, int x, int y,int damage)
        {
            NormalEgg e = new NormalEgg(context, damage, x, y-20);
            _eggs.Add(e);
            return e;
        }

        public RottenEgg CreateRottenEgg(Map context, int x, int y, int damage)
        {
            RottenEgg e = new RottenEgg(context, damage, x, y - 20);
            _eggs.Add(e);
            return e;
        }
        public RobotEgg CreateRobotEgg(Map context, int x, int y, int damage)
        {
            RobotEgg e = new RobotEgg(context, damage, x, y - 20);
            _eggs.Add(e);
            return e;
        }


        public List<Tower> GetTower
        {
            get { return _towers; }
        }
    }
}