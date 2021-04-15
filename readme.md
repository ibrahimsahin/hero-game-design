there is a hero, which   has weapons to battle with the enemy, has strength to stay alive in 
the game. 
  There is an only one hero in the game. It has attributes like name, strength, number of 
enemy  killed,  list  of  killed  enemies,  weapon  in  use;  and it  has  methods  like  get/set 
strength, decrease strength by a value.
  There are lots of enemies in the game. They are defined before the game starts and 
battles with hero until it dies.
  There are three types of enemies: wolf, human, and monster. They are derived from 
enemy class.  Enemies  have attributes like strength and methods like damage, which 
are differs by types of enemies
  There  are  four  kinds  of  weapons:  punch  (default),  club,  sword,  and  gun.  They  are 
derived from weapon class. Weapons can be used only by hero.
  Hero can hold only one weapon at a time. He must drop  the old one in order to take 
new one. (He doesn’t have to take a worse weapon than he holds.)
  Gun has 7 bullets. So after 7 shots, he must throw the gun and continue his battle with 
punch until he finds another weapon. 
  Damage given by battling  of hero and enemy is in this way: Let’s say our hero has 
strength of 150 and enemy has 30. Hero holds a sword as a weapon (which has a 
damage  of  10).  And  damage  of  enemy  is  5.  We  assume  that  they  are  acting 
simultaneously and result of the simulation is: 
Battle with Wolf (strength: 30 , damage: 5)
o  Strengths-->  Hero: 150  Wolf: 30
o  Strengths-->  Hero: 145  Wolf: 20
o  Strengths-->  Hero: 140  Wolf: 10
o  Strengths-->  Hero: 135  Wolf: Dead
  Whenever a  character’s  strength falls  to  zero  (or  smaller  than  zero)  that  means  the 
character is dead.

INPUTS:
Your program has two input files. One of them is to control strengths and damages of the all 
objects in the game. (lines starts with “--“ are comment lines)
Example “control.txt” file (which will be used for testing your program firstly. In addition several 
input files will be used to explore your application ’s robustness level);

-- definition of hero
-- Hero strength_of_hero
Hero 300
-- definition of weapons 
-- Weapon weapon_type  damage_of_weapon
Weapon Punch 3
Weapon Club 7
Weapon Sword 10
Weapon Gun 20
-- definition of enemies
-- Enemy enemy_type strength_of_enemy damage_of_enemy
Enemy Wolf 8 4
Enemy Human 20 10
Enemy Monster 50 20


Other file contains commands for simulate the game.
Example “simulation.txt” file;

-- Our Hero meets with an enemy in his road
-- AddEnemy enemy_type
AddEnemy Wolf
AddEnemy Wolf
-- Our Hero meets with a weapon in his road
-- AddWeapon weapon_type
AddWeapon Club
AddEnemy Wolf
AddEnemy Human
AddEnemy Human
AddWeapon Sword
AddEnemy Human
AddEnemy Wolf
AddEnemy Wolf
AddWeapon Club
AddEnemy Human
AddWeapon Gun
AddEnemy Human
AddEnemy Wolf
AddEnemy Wolf 
AddEnemy Monster
AddEnemy Wolf
AddEnemy Wolf
AddWeapon Sword
AddEnemy Human

OUTPUT:
After  execution,  output  of  the  program  is  displayed  both  on  the  screen  and  written  to  a  file 
named “final.txt”.
Result of the example input given below;
Game started
------Hero -> Strength: 300 | Weapon type: Punch | Weapon damage: 3
Battle with Wolf (strength: 8 , damage: 4)
>>>>> Strengths--> Hero: 300 | Wolf: 8
>>>>> Strengths--> Hero: 296 | Wolf: 5
>>>>> Strengths--> Hero: 292 | Wolf: 2
>>>>> Strengths--> Hero: 288 | Wolf: DEAD
Hero -> Strength: 288 | Weapon type: Punch | Weapon damage: 3
Battle with Wolf (strength: 8 , damage: 4)
>>>>> Strengths--> Hero: 288 | Wolf: 8
>>>>> Strengths--> Hero: 284 | Wolf: 5
>>>>> Strengths--> Hero: 280 | Wolf: 2
>>>>> Strengths--> Hero: 276 | Wolf: DEAD
Hero -> Strength: 276 | Weapon type: Punch | Weapon damage: 3
Hero takes weapon: Club
Hero -> Strength: 276 | Weapon type: Club | Weapon damage: 7
Battle with Wolf (strength: 8 , damage: 4)
>>>>> Strengths--> Hero: 276 | Wolf: 8
>>>>> Strengths--> Hero: 272 | Wolf: 1
>>>>> Strengths--> Hero: 268 | Wolf: DEAD
Hero -> Strength: 268 | Weapon type: Club | Weapon damage: 7
Battle with Human (strength: 20 , damage: 10)
>>>>> Strengths--> Hero: 268 | Human: 20
>>>>> Strengths--> Hero: 258 | Human: 13
>>>>> Strengths--> Hero: 248 | Human: 6
>>>>> Strengths--> Hero: 238 | Human: DEAD
Hero -> Strength: 238 | Weapon type: Club | Weapon damage: 7
Battle with Human (strength: 20 , damage: 10)
>>>>> Strengths--> Hero: 238 | Human: 20
>>>>> Strengths--> Hero: 228 | Human: 13
>>>>> Strengths--> Hero: 218 | Human: 6
>>>>> Strengths--> Hero: 208 | Human: DEAD
Hero takes weapon: Sword
Hero -> Strength: 208 | Weapon type: Sword | Weapon damage: 10
Battle with Human (strength: 20 , damage: 10)
>>>>> Strengths--> Hero: 208 | Human: 20
>>>>> Strengths--> Hero: 198 | Human: 10
>>>>> Strengths--> Hero: 188 | Human: DEAD
Hero -> Strength: 188 | Weapon type: Sword | Weapon damage: 10
Battle with Wolf (strength: 8 , damage: 4)
>>>>> Strengths--> Hero: 188 | Wolf: 8
>>>>> Strengths--> Hero: 184 | Wolf: DEAD
Hero -> Strength: 184 | Weapon type: Sword | Weapon damage: 10
Battle with Wolf (strength: 8 , damage: 4)
>>>>> Strengths--> Hero: 184 | Wolf: 8 
>>>>> Strengths--> Hero: 180 | Wolf: DEAD
Hero -> Strength: 180 | Weapon type: Sword | Weapon damage: 10
No need to take Club
Battle with Human (strength: 20 , damage: 10)
>>>>> Strengths--> Hero: 180 | Human: 20
>>>>> Strengths--> Hero: 170 | Human: 10
>>>>> Strengths--> Hero: 160 | Human: DEAD
Hero takes weapon: Gun (7 bullets)
Hero -> Strength: 160 | Weapon type: Gun (7 bullets) | Weapon damage: 20
Battle with Human (strength: 20 , damage: 10)
>>>>> Strengths--> Hero: 160 | Human: 20
>>>>> Strengths--> Hero: 150 | Human: DEAD
Hero -> Strength: 150 | Weapon type: Gun (6 bullets) | Weapon damage: 20
Battle with Wolf (strength: 8 , damage: 4)
>>>>> Strengths--> Hero: 150 | Wolf: 8
>>>>> Strengths--> Hero: 146 | Wolf: DEAD
Hero -> Strength: 146 | Weapon type: Gun (5 bullets) | Weapon damage: 20
Battle with Wolf (strength: 8 , damage: 4)
>>>>> Strengths--> Hero: 146 | Wolf: 8
>>>>> Strengths--> Hero: 142 | Wolf: DEAD
Hero -> Strength: 142 | Weapon type: Gun (4 bullets) | Weapon damage: 20
Battle with Monster (strength: 50 , damage: 20)
>>>>> Strengths--> Hero: 142 | Monster: 50
>>>>> Strengths--> Hero: 122 | Monster: 30
>>>>> Strengths--> Hero: 102 | Monster: 10
>>>>> Strengths--> Hero: 82 | Monster: DEAD
Hero -> Strength: 82 | Weapon type: Gun (1 bullets) | Weapon damage: 20
Battle with Wolf (strength: 8 , damage: 4)
>>>>> Strengths--> Hero: 82 | Wolf: 8
>>>>> Strengths--> Hero: 78 | Wolf: DEAD
Hero -> Strength: 78 | Weapon type: Gun (0 bullets) | Weapon damage: 20
Hero drops weapon: Gun 
Hero -> Strength: 78 | Weapon type: Punch | Weapon damage: 3
Battle with Wolf (strength: 8 , damage: 4)
>>>>> Strengths--> Hero: 78 | Wolf: 8
>>>>> Strengths--> Hero: 74 | Wolf: 5
>>>>> Strengths--> Hero: 70 | Wolf: 2
>>>>> Strengths--> Hero: 66 | Wolf: DEAD
Hero takes weapon: Sword
Hero -> Strength: 66 | Weapon type: Sword | Weapon damage: 10
Battle with Human (strength: 20 , damage: 10)
>>>>> Strengths--> Hero: 66 | Human: 20
>>>>> Strengths--> Hero: 56 | Human: 10
>>>>> Strengths--> Hero: 46 | Human: DEAD
Enemies successfully defeated
Number of enemies killed
Wolf: 9
Human: 6
Monster: 1
------Game finished