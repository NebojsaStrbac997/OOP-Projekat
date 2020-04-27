using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2._2
{
    class Armor 
    {
        protected int resistance;
        protected string type;

        public Armor(int resistance,string type) 
        {
            this.resistance = resistance;
            this.type = type;
        }
        public int getResistance
        {
            get { return resistance; }
            set { resistance = value; }

        }
        public string getType
        {
            get { return type; }
            set { type = value; }

        }
    }
}
