using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{

    public class Character : EntitiesObject
    {

        public enum RelationshipsEnum
        {
            FRIENDSHIP,
            LOVE,
            HATRED,
            RIVALRY
        }

        private int bravoury;
        private int crazyness;
        private String firstName;
        private String lastName;
        private int pv;
        private Dictionary<Character, RelationshipsEnum> relationships;
        private static int cpt;

        public Character(int braveLvl, int crazyLvl, String fn, String ln)
        {
            bravoury = braveLvl;
            crazyness = crazyLvl;
            firstName = fn;
            lastName = ln;
            pv = 100;
            relationships = new Dictionary<Character, RelationshipsEnum>(0);
            cpt++;
            id = cpt;
        }

        public void AddRelatives(Character c, RelationshipsEnum r)
        {
            relationships.Add(c, r);
        }

        public String toString()
        {
            return "I am " + firstName + " " + lastName + ". I have " + pv + " hp" + ". I have" + bravoury + " in bravoury and " + crazyness + " in crazyness.";
        }

        public int Bravoury { get => bravoury; set => bravoury = value; }
        public int Crazyness { get => crazyness; set => crazyness = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Pv { get => pv; set => pv = value; }
        public Dictionary<Character, RelationshipsEnum> Relationships { get => relationships; set => relationships = value; }
    }
}
