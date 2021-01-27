using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class GameCharacter
    {
        public string name;
        public int health;
        public int shield;
        public int lives;

        public void ShowStats()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine();

        }
        public void TakeDamage(int Damage)
        {
            Console.WriteLine(name + " is about to take " + Damage + " damage");
            Console.WriteLine();
            int remainingDamage = Damage - shield;
            shield = shield - Damage;

            if (shield <= 0)
            {
                
                Console.WriteLine(name + "'s shield has broke!");
                Console.WriteLine();
                shield = 0;
                health = health - remainingDamage;

            }
            if (health <= 0)
            {
                health = 0;
                lives = lives - 1;
                Console.WriteLine(name + " has died....");
                Console.WriteLine();
                //doesn't take anymore damage after player dies.
                Damage = 0;
                remainingDamage = 0;
                //reset after life is lost
                health = 100;
                shield = 100;
            }
            if (lives <= 0){
                lives = 0;
                health = 0;
                shield = 0;
                Console.WriteLine("Game Over!");
                Console.WriteLine();
            }

        }
        public void Heal( int hp )
        {
            health = health + hp;
            Console.WriteLine(name + " is about to heal " + hp + " health points.");
            Console.WriteLine();
            if (health >= 100)
            {
                health = 100;
            }
        }
        public void RegenShield(int sp)
        {
            shield = shield + sp;
            Console.WriteLine(name + " is about regenerate " + sp + " shield.");
            Console.WriteLine();
            if (shield >= 100)
            {
                shield = 100;
            }


        }
        public void Reset()
        {
            Console.WriteLine(name + "'s stats have reset!");
            Console.WriteLine();
            health = 100;
            shield = 100;
            
        }

        
    }
}
