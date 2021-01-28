using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Player : GameCharacter
    {
        public Player()
        {
            //name = "Luke Skywalker";
            health = 100;
            shield = 100;
            lives = 3;
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
                Console.WriteLine("Game Over!");
                Console.WriteLine();
            }
        }
        public new void ShowStats()
        {
            //lets you know who is who
            Console.WriteLine("PLAYER:");
            base.ShowStats();
        }
        public new void Reset()
        {
            //lives reset based off emeny and player
            //player has 3 lives....
            base.Reset();
            lives = 3;
        }
    }
}
