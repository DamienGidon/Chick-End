using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class HenCreater
    {
        Map _map;
        Dictionary<string, int> _hensCost = new Dictionary<string, int>();

        public HenCreater(Map map)
        {
            _map = map;
            FillList();
        }

        public HenCreater()
        {
            FillList();
        }

        public void FillList()
        {
            _hensCost.Add("Hen", 50);
            _hensCost.Add("BomberHen", 200);
            _hensCost.Add("ExplosiveEgg", 400);
            _hensCost.Add("OldHen", 150);
            _hensCost.Add("Rooster", 1000);
            _hensCost.Add("Baker", 400);
            _hensCost.Add("Butcher", 300);
            _hensCost.Add("InfantryFarmer", 300);
            _hensCost.Add("GunnerFarmer", 450);
        }

        public int SellUnit(Tower tower)
        {
            string p = Convert.ToString(tower).Remove(0,20);
            return _hensCost[p] / 2;
        }

        public int HensCost(string tower)
        {
            return _hensCost[tower];
        }

        public void CreateHen(int ligne, int colonne, Map context)
        {
            Tower t = new Hen( _map.Square[ligne, colonne]);
            _map.Square[ligne, colonne].Tower = t;
            _map.Towers.Add(t);
        }
    }
}
