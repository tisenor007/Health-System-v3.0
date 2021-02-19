using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Player : GameCharacter
    {
        //constructor
        public Player(string playerName)
        {
            //name = "Luke Skywalker";
            name = playerName;
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
        public void extralife()
        {
          
            Console.WriteLine(name + " has just picked up an extra life");
            Console.WriteLine();
            lives = lives + 1;
            if (lives >= 3)
            {
                //caps lives at 3
                //also there is no extra life method for 
                lives = 3;
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
