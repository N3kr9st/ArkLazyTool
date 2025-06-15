using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkLazyTool
{
    internal class Dino
    {   
        public static String[] statNames = {"Hp","Damage","Speed","Food","Ox","Weight","Stamina","Torpor"};
        int hp,damage,speed,food,ox,weight,stamina,torpor = 0;
        public Dino(int[] values)
        {
            this.hp = values[0];
            this.damage = values[1];
            this.speed = values[2];
            this.food = values[3];
            this.ox = values[4];
            this.weight = values[5];
            this.stamina = values[6];
            this.torpor = values[7];
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
