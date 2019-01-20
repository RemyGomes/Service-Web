using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Territory : EntitiesObject
    {
        public enum TerritoryType
        {
            SEA,
            MOUNTAIN,
            LAND,
            DESERT
        }
        private static int cpt = 0;
        private TerritoryType type;
        private House owner;

        public Territory(House h, TerritoryType t)
        {
            owner = h;
            type = t;
            cpt++;
            id = cpt;
        }

        public TerritoryType Type { get => type; set => type = value; }
        public House Owner { get => owner; set => owner = value; }
    }
}
