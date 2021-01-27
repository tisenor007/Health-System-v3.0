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
            name = "Luke Skywalker";
            health = 100;
            shield = 100;
            lives = 3;
        }
        public new void ShowStats()
        {
            Console.WriteLine("PLAYER:");
            base.ShowStats();
        }
        public new void Reset()
        {
            base.Reset();
            lives = 3;
        }
    }
}
