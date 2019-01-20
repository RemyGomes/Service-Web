using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Fight : EntitiesObject
    {
        private House houseChallenger1;
        private House houseChallenger2;
        private House winningHouse;
        private static int cpt = 0;

        public Fight(House h1, House h2)
        {
            houseChallenger1 = h1;
            houseChallenger2 = h2;
            cpt++;
            id = cpt;
        }

        public House HouseChallenger1 { get => houseChallenger1; set => houseChallenger1 = value; }
        public House HouseChallenger2 { get => houseChallenger2; set => houseChallenger2 = value; }
        public House WinningHouse { get => winningHouse; set => winningHouse = value; }
    }
}
