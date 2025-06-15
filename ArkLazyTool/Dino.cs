using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkLazyTool
{
    internal class Dino
    {   
        int hp,damage,speed,food,ox,weight,stamina,torpor;
        public Dino(int hp, int damage, int speed, int food, int ox, int weight, int stamina, int torpor)
        {
            this.hp = hp;
            this.damage = damage;
            this.speed = speed;
            this.food = food;
            this.ox = ox;
            this.weight = weight;
            this.stamina = stamina;
            this.torpor = torpor;


        }
    }
}
