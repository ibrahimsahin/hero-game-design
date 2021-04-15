using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Sword : Weapon//sword is a weapon (inheritance)
    {

        public Sword(string type, int damage)//constructor of the sword
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