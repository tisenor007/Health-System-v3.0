using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Enemy : GameCharacter
    {
        public Enemy()
        {
            //name = "Darth Vader";
            health = 100;
            shield = 100;
            //no enemy has more than 1 life, that would be unfair to player....
            lives = 1;
        }
        public new void TakeDamage(int Damage)
        {
            base.TakeDamage(Damage);
            if (lives <= 0)
            {
                //gameover
                lives = 0;
                health = 0;
                shield = 0;
                Console.WriteLine("GAME WON!");
                Console.WriteLine();
            }
        }
        public new void ShowStats()
        {
            //lets you know who is who
            Console.WriteLine("ENEMY:");
            base.ShowStats();
        }
        public new void Reset()
        {
            //lives reset based off enemy and player
            //enemy only has 1 life
            base.Reset();
            lives = 1;
        }
    }
}
