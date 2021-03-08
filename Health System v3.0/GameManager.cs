using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class GameManager
    {
        public void RunGame()
        {
            Console.WriteLine("Game is running");
            UnitTest unitTest = new UnitTest();

            unitTest.RunUnitTest();
        }
    }
}
