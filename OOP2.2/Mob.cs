using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2._2
{
    class Mob : Character
    {
        
        public string race;
        
        public Mob(string name,int hp, int dmg) :base(name,hp,dmg)
        {
            this.name = name;
            this.hp = hp;
            this.dmg = dmg;
            
        }
        public override void attack(int dmg, ProgressBar hp,Armor armor)
        {
            if (hp.Value!=0) 
            {
                hp.Value -= (dmg - armor.getResistance);
            }
        }

        public string getsetRace { get { return race; } set { race = value; } }

        public int getsetMobArmor { get; set; }

    }
}
