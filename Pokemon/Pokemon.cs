using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    internal class Pokemon
    {
        static Form1 pokemonForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        public string name;
        public string[] type;
        public int level;
        public int[] IVs = {0,0,0,0,0,0};
        public int[] EVs;
        public Attacks[] Attacks;

        public int hp;
        public int attack;
        public int specialAttack;
        public int defense;
        public int specialDefense;
        public int speed;

        public int status;
        public bool fainted = false;

        public Pokemon(string name, string[] type, int level, int[] _EVs, Attacks[] attacks, int hp, int attack, int defense, int specialAttack, int specialDefense, int speed, int status)
        {
            this.EVs = _EVs;
            this.name = name;
            this.type = type;
            this.level = level;
            this.Attacks = attacks;
            this.hp = hp + (EVs[0] / 4) + (Convert.ToInt32(level * 1.30));
            this.attack = attack + (EVs[1] / 4) + (Convert.ToInt32(level * 1.30)); 
            this.defense = defense + (EVs[2] / 4) + (Convert.ToInt32(level * 1.30));
            this.specialAttack = specialAttack + (EVs[3] / 4) + (Convert.ToInt32(level * 1.30));
            this.specialDefense = specialDefense + (EVs[4] / 4) + (Convert.ToInt32(level * 1.30));
            this.speed = speed + (EVs[5] / 4) + (Convert.ToInt32(level * 1.30));
            this.status = status;

            Random random = new Random();
            for(int i = 0; i < IVs.Length; i++)
            {
                IVs[i] = random.Next(1, 32);
            }
        }

        public void Attack(Attacks attack, Pokemon enemy)
        {
            Random random = new Random();
            if (random.Next(0, 101) >= attack.hitChance)
            {
                enemy.hp -= attack.basePower;
                if (attack.basePower >= enemy.hp)
                {
                    enemy.Faint(true);
                }
            }
        }

        public void Faint(bool enemy)
        {
            this.fainted = true;
            this.hp = 0;
            if (enemy)
            {
                pokemonForm.enemyPicture.Image = null;
            }
        }

    }
}
