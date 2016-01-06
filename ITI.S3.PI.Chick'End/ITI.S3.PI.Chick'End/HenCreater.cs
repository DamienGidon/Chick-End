using System;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class HenCreater
    {
        Map _map;
        int _henCost = 50;
        int _bomberHenCost = 200;
        int _explosiveEgg = 400;
        int _oldHenCost = 150;
        int _roosterCost = 1000;

        int _bakerCost = 400;
        int _butcherCost = 300;
        int _infantryFamerCost = 300;
        int _gunnerFarmerCost = 450;

        public HenCreater(Map map)
        {
            _map = map;
        }

        public HenCreater()
        {
        }

        public int HenCost
        {
            get { return _henCost; }
        }

        public int BomberHenCost
        {
            get { return _bomberHenCost; }
        }

        public int ExplosiveEggCost
        {
            get { return _explosiveEgg; }
        }

        public int OldHenCost
        {
            get { return _oldHenCost; }
        }

        public int RoosterCost
        {
            get { return _roosterCost; }
        }

        public int BakerCost
        {
            get { return _bakerCost; }
        }

        public int ButcherCost
        {
            get { return _butcherCost; }
        }

        public int InfantryFarmerCost
        {
            get { return _infantryFamerCost; }
        }

        public int GunnerFarmerCost
        {
            get { return _gunnerFarmerCost; }
        }

        public void CreateHen(int ligne, int colonne, Map context)
        {
            Tower t = new Hen( _map.Square[ligne, colonne]);
            _map.Square[ligne, colonne].Tower = t;
            _map.Towers.Add(t);
        }
    }
}
