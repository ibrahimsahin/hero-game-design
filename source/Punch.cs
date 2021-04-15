using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Punch : Weapon//punch is a weapon (inheritance)
    {

        public Punch(string type, int damage)//constructor of the punch
        {
            type_ = type;
            damage_ = damage;
        }
        public string getType()//getters and setters
        {
            return type_;
        }
        public int getDamage()
        {
            return damage_;
        }


    }
}
