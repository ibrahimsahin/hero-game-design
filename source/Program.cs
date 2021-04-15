using System;
using System.IO; // TextWriter, StreamWriter 
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class MyClass
    {

        public void Load_Pro(MyClass mn)
        {
            int i = 0;// i is for loops
            Enemy[] en = new Enemy[3];// create an array for access enemies
            Weapon[] w = new Weapon[4];// create an array for access weapons
            for (i = 0; i < 3; i++)//create 3 enemy and throw to the array
            {
                Enemy enmy = new Enemy();
                en[i] = enmy;
            }
            for (i = 0; i < 4; i++)//create 4 weapon and throw to the array
            {
                Weapon wpn = new Weapon();
                w[i] = wpn;
            }
            Hero h = new Hero(0);//create hero


            TextReader tr = new StreamReader("control.txt");//read firstly control.txt
            string read = tr.ReadLine();

            int e_count = 0;
            int w_count = 0;

            while (read != null)//read until the end of the file
            {
                string[] look = read.Split(' ');// read until the space
                if (look[0] == "Hero")
                {
                    int st = int.Parse(look[1]);//assign the heros strenght
                    h.strenght_ = st;

                }
                if (look[0] == "Enemy")
                {
                    int st = int.Parse(look[2]);
                    int dmg = int.Parse(look[3]);
                    en[e_count].damage_ = dmg;// assign the enemies properties
                    en[e_count].strenght_ = st;
                    en[e_count].type_ = look[1];
                    e_count++;
                }
                if (look[0] == "Weapon")
                {
                    int dmg = int.Parse(look[2]);
                    w[w_count].type_ = look[1];// assign weapons properties
                    w[w_count].damage_ = dmg;
                    w_count++;
                }
                read = tr.ReadLine();//read the new line
            }
            tr.Close();// close the stream
            mn.Simulate(h, en, w, mn);//send the object and object arrays to this function

        }

        public int find_index(Weapon[] w, string name)//this function return the index of the weapon than type 
        {
            int i = 0;
            for (i = 0; i < 4; i++)
                if (w[i].type_ == name)
                    break;
            return i;
        }
        public int find_enemy(Enemy[] en, string name)//this function return the index of the enemy than type 
        {
            int i = 0;
            for (i = 0; i < 3; i++)
                if (en[i].type_ == name)
                    break;
            return i;
        }

        public void Simulate(Hero h, Enemy[] en, Weapon[] w, MyClass mn)
        {
            int w_counter = 0;
            int h_counter = 0;
            int m_counter = 0;
            TextReader tr = new StreamReader("simulation.txt");//read simulation.txt file
            TextWriter tw = new StreamWriter("final.txt");// we will write to this file (final.txt)
            string read = tr.ReadLine();// read line from file
            int g = mn.find_index(w, "Gun");//g is index of the gun
            Gun gun = new Gun(w[g].type_, w[g].damage_, 7);//create a gun
            int def_index = mn.find_index(w, "Punch");//def_index is index of the default weapon
            Weapon default_ = new Punch(w[def_index].type_, w[def_index].damage_);//create a punch
            h.setHold(default_);//hero using punch at first
            tw.WriteLine("Game started\n------\n");//game is starting
            while (read != null)// read all lines
            {
                string[] look = read.Split(' ');// read until the space
                if (look[0] == "AddEnemy")//command AddEnemy from file
                {
                    int en_index = find_enemy(en, look[1]);
                    if (look[1] == "Wolf")
                    {
                        Enemy wo = new Wolf(en[en_index].strenght_, en[en_index].type_, en[en_index].damage_);
                        h.setFight(wo); //if enemy is a wolf,create a wolf and assign to heros enemy
                    }
                    if (look[1] == "Human")
                    {
                        Enemy hu = new Human(en[en_index].strenght_, en[en_index].type_, en[en_index].damage_);
                        h.setFight(hu); //if enemy is a human,create a wolf and assign to heros enemy
                    }
                    if (look[1] == "Monster")
                    {
                        Enemy mo = new Wolf(en[en_index].strenght_, en[en_index].type_, en[en_index].damage_);
                        h.setFight(mo); //if enemy is a monster,create a wolf and assign to heros enemy

                    }
                    if (h.getHold().type_ == "Gun")// gun is special,because it has bullets
                    {   //write the informations about game damage ,enemy,weapon etc.
                        tw.WriteLine("Hero -> Strength:" + h.strenght_ + "| Weapon type:" + h.getHold().type_ + "(" + gun.bullet_ + ")" + "| Weapon damage:" + h.getHold().damage_);
                    }
                    else
                    {
                        tw.WriteLine("Hero -> Strength:" + h.strenght_ + "| Weapon type:" + h.getHold().type_ + "| Weapon damage:" + h.getHold().damage_);
                        tw.WriteLine("\nBattle with " + h.getFight().type_ + " (strength: " + h.getFight().strenght_ + ", damage: " + h.getFight().damage_ + ")");
                    }

                    while (h.strenght_ >= 0 && h.getFight().strenght_ >= 0)//continue to a death
                    {
                        if (h.getHold().type_ == "Gun")//if hold weapon is gun
                        {
                            gun.bullet_--;// decrease the bullets
                        }
                        tw.WriteLine(">>>>> Strengths--> Hero: " + h.strenght_ + "| " + h.getFight().type_ + ":" + h.getFight().strenght_ + "\n");
                        h.strenght_ = h.strenght_ - h.getFight().damage_;//decrease heros strenght step by step for enemies damage
                        h.getFight().strenght_ = h.getFight().strenght_ - h.getHold().damage_;//decrease the enemies strenght
                        if (h.strenght_ <= 0)//if hero has died
                            break;
                        if (h.getHold().type_ == "Gun" && gun.bullet_ == 0) //drop the gun
                        {
                            tw.WriteLine("Hero drops weapon: Gun");
                            h.setHold(default_);//take default weapon (punch)
                            tw.WriteLine("Hero -> Strength:" + h.strenght_ + "| Weapon type:" + h.getHold().type_ + "| Weapon damage:" + h.getHold().damage_);
                        }
                        if (h.getFight().strenght_ <= 0)//if enemy is died
                        {

                            tw.WriteLine(">>>>> Strengths--> Hero: " + h.strenght_ + "| " + h.getFight().type_ + ":DEAD\n");
                            if (h.getFight().type_ == "Wolf")
                                w_counter++;
                            else if (h.getFight().type_ == "Human")
                                h_counter++;
                            else if (h.getFight().type_ == "Monster")
                                m_counter++;
                            break;
                        }

                    }//end of the fight
                    if (h.strenght_ <= 0)// if hero is died
                        break;//broke the loop
                }//if meet with an enemy

                if (look[0] == "AddWeapon")//command AddEnemy from file
                {
                    int index = find_index(w, look[1]);
                    if (h.getHold().damage_ > w[index].damage_)// if holding weapon is better
                        tw.WriteLine("No need to take" + w[index].type_);
                    else if ((h.getHold().damage_ < w[index].damage_))
                    {
                        if (h.getHold().type_ == "Gun" && gun.bullet_ == 0)
                        {// if finish the bullets of the gun
                            tw.WriteLine("Hero drops weapon: Gun");//drop the gun
                        }
                        tw.WriteLine("Hero takes weapon:" + w[index].type_);
                        if (w[index].type_ == "Punch")
                        {
                            Weapon get = new Punch(w[index].type_, w[index].damage_);
                            h.setHold(get);// take the punch
                        }
                        else if (w[index].type_ == "Sword")
                        {
                            Weapon get = new Sword(w[index].type_, w[index].damage_);
                            h.setHold(get);// take the sword
                        }
                        else if (w[index].type_ == "Club")
                        {
                            Weapon get = new Club(w[index].type_, w[index].damage_);
                            h.setHold(get);//take the club
                        }
                        else if (w[index].type_ == "Gun")
                        {
                            Weapon get = new Gun(w[index].type_, w[index].damage_, 7);
                            h.setHold(get);//take the gun
                        }
                    }
                }

                read = tr.ReadLine();// read all datas
            }//read all line
            if (h.strenght_ > 0)//end of the game,write the games summary
            {
                tw.WriteLine("Enemies successfully defeated\nNumber of enemies killed");
                tw.WriteLine("Wolf:" + w_counter);
                tw.WriteLine("Human:" + h_counter);
                tw.WriteLine("Monster:" + m_counter);
                tw.WriteLine("------\nGame finished");
            }
            else//if hero died
            {
                tw.WriteLine("Operation failed\nHero was died!!!");
                tw.WriteLine("Wolf:" + w_counter);
                tw.WriteLine("Human:" + h_counter);
                tw.WriteLine("Monster:" + m_counter);
                tw.WriteLine("------\nGame finished");
            }

            tr.Close();//close the streamreader
            tw.Close();//close the streamwriter

        }
        public void write_screen()
        {
            TextReader tr = new StreamReader("final.txt");
            Console.WriteLine(tr.ReadToEnd());


        }
        public static void Main()
        {
            MyClass mn = new MyClass();
            mn.Load_Pro(mn);// read all datas
            mn.write_screen();

        }
    }
}

