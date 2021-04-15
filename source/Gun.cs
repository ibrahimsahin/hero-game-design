using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Gun : Weapon//gun is a weapon (inheritance)
    {
        public int bullet_;//specially,the gun has bullet

        public Gun(string type, int damage, int bullet)//constructor of the gun
        {
            type_ = type;
            damage_ = damage;
            bullet_ = bullet;

        }
        public string getType()//getters and setters
        {
            return type_;
        }
        public int getDamage()
        {
            return damage_;
        }
        public int getBullet()
        {
            return bullet_;
        }
        public void setBullet(int bullet)
        {
            bullet_ = bullet;
        }

    }
}