using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Monster : Enemy// monster is an enemy also
    {
        public Monster(int strenght, string type, int damage)//constructor of the monster
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
