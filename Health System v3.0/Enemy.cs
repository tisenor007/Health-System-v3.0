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
            name = "Darth Vader";
            health = 100;
            shield = 100;
            //no enemy has more than 1 life, that would be unfair to player....
            lives = 1;
        }
        public new void ShowStats()
        {
            Console.WriteLine("ENEMY:");
            base.ShowStats();
        }
        public new void Reset()
        {
            base.Reset();
            lives = 1;
        }
    }
}
