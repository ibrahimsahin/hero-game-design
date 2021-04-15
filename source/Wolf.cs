using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Wolf : Enemy// wolf is an enemy also
    {
        public Wolf(int strenght, string type, int damage)//constructor of the wolf
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
