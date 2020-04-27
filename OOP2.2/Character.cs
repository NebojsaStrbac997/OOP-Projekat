using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2._2
{
     abstract class Character
     {
       protected string name; 
       protected int hp;
       protected int dmg;
       
       

        public Character(string name,int hp,int dmg) 
        {
            this.name = name;
            this.hp = hp;
            this.dmg = dmg;
            
        }

        public virtual void attack(int dmg,ProgressBar hp,Armor armor)
        {
            hp.Value -= dmg;   
        }

        public string getsetname { get { return name; } set { name = value; } }
        public int getsetDmg { get { return dmg; } set { dmg = value; } }
        public int getsetHp { get { return hp; } set { hp = value; } }

     }


}
