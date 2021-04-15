
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Hero
    {
        public int strenght_;  //properties of the hero
        public Weapon hold_;
        public Enemy fight_;

        public Hero(int strenght) //getters and setters
        {
            strenght_ = strenght;
        }

        public int getStrenght()
        {
            return strenght_;
        }

        public void setHold(Weapon w)
        {
            hold_ = w;
        }

        public Weapon getHold()
        {
            return hold_;
        }
        public void setFight(Enemy e)
        {
            fight_ = e;
        }
        public Enemy getFight()
        {
            return fight_;
        }
    }

}