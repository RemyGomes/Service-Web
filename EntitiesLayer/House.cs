using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class House : EntitiesObject
    {
        private List<Character> housers;
        private String name;
        private int number;
        private static int cpt;

        public House(String n)
        {
            name = n;
            number = 0;
            housers = new List<Character>(0);
            cpt++;
            id = cpt;
        }

        public void AddHouser(Character c)
        {
            housers.Add(c);
        }

        public List<Character> Housers { get => housers; set => housers = value; }
        public string Name { get => name; set => name = value; }
        public int Number { get => number; set => number = value; }
    }
}
