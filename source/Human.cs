using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Human : Enemy// human is an enemy also
    {
        public Human(int strenght, string type, int damage)//constructor of the human
        {
            strenght_ = strenght;
            type_ = type;
            damage_ = damage;
        }

        public int getStrenght()
        {
            return strenght_;
        }
        public string getType()
        {
            return type_;
        }
        public int getDamage()
        {
            return damage_;
        }
    }
}
