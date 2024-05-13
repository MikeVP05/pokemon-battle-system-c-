using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Pokemon
    {
        public int hp;
        public string name;
        public string[] type;
        public int level;
        public int[] IVs = {0,0,0,0,0,0};
        public int[] EVs;
        public Attacks[] Attacks;
        public int attack;
        public int specialAttack;
        public int defense;
        public int specialDefense;
        public int speed;
        public int status;

        public Pokemon(int hp, string name, string[] type, int level, int[] _EVs, Attacks[] attacks, int attack, int defense, int specialAttack, int specialDefense, int speed, int status)
        {
            this.EVs = _EVs;
            this.hp = hp + (EVs[0] / 4);
            this.name = name;
            this.type = type;
            this.level = level;
            this.attack = attack;
            this.Attacks = attacks;
            this.specialAttack = specialAttack;
            this.defense = defense;
            this.specialDefense = specialDefense;
            this.speed = speed;
            this.status = status;

            Random random = new Random();
            for(int i = 0; i < IVs.Length; i++)
            {
                IVs[i] = random.Next(1, 32);
            }
        }
    }
}
