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
        public int GetHp() { return hp; }
        public int GetDamage() { return damage; }
        public int GetSpeed() { return speed; }
        public int GetFood() { return food; }
        public int GetOx() { return ox; }
        public int GetWeight() { return weight; }
        public int GetStamina() { return stamina; }
        public int GetTorpor() { return torpor; }
        public void SetHp(int hp) { this.hp = hp; }
        public void SetDamage(int damage) { this.damage = damage; }
        public void SetSpeed(int speed) { this.speed = speed; }
        public void SetFood(int food) { this.food = food; }    
        public void SetOx(int ox) { this.ox = ox; }
        public void SetWeight(int weight) { this.weight = weight; }
        public void SetStamina(int stamina) { this.stamina = stamina; }
        public void SetTorpor(int torpor) { this.torpor = torpor; }

        }
}
