using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Attacks
    {
        public string name;
        public string type;
        public bool special;
        public int basePower;
        public double hitChance;

        public string effect;
        public double effectChance;

        public Attacks(string name, string type, bool special, int basePower, double hitChance, string effect, double effectChance)
        {
            this.name = name;
            this.type = type;
            this.special = special;
            this.basePower = basePower;
            this.hitChance = hitChance;
            this.effect = effect;
            this.effectChance = effectChance;
        }
    }
}