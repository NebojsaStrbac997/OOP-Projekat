using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2._2
{
    class Heroj : Character
    {
        private string heroClass;
        private int mana;      
        protected Armor armor;

        public Heroj(string name,int hp, int mana, int dmg, string heroclass,Armor armor) : base(name,hp, dmg)
        {
            this.hp = hp;
            this.mana = mana;
            this.name = name;
            this.dmg = dmg;
            this.heroClass = heroclass;
            this.armor = armor;
            
        }

        public string getName
        {
            get { return name; }
            set { name = value; }
        }
        public string getHeroClass
        {
            get { return heroClass; }
            set { heroClass = value; }
        }
        public int getMana
        {
            get { return mana; }
            set { mana = value; }
        }
        public Armor getsetHerojArmor
        {
            get { return armor; }
            set { armor = value; }
        }


    }
}
