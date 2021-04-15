using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Club : Weapon//club is a weapon (inheritance)
    {

        public Club(string type, int damage)//constructor of the club
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