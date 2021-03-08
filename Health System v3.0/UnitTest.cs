using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Health_System_v3._0
{
    class UnitTest
    {
        public void RunUnitTest()
        {
            //no longer need debug console.writelines
            Console.WriteLine("Unit Testing started");

            Player player = new Player();//playerName);//instantiation and declaration
            Enemy enemy = new Enemy();//enemyName);//instantiation and declaration
            Debug.Assert(player != null);

            //Gameplay
           
          

            player.UnitTest();
            enemy.UnitTest();
           
            //player.TakeDamage(175);
            //player.extralife();
            //player.ShowStats();
            //player.Heal(50);
            //player.ShowStats();
            //enemy.TakeDamage(25);
            //enemy.ShowStats();
            //enemy.RegenShield(73);
            //enemy.ShowStats();
            //player.TakeDamage(115);
            //player.ShowStats();
            //enemy.TakeDamage(200);
            //enemy.ShowStats();
           //enemy.Reset();
            //enemy.ShowStats();
            //player.TakeDamage(230);
            //player.ShowStats();
            //shows that nothing accepts negative values
            //player.Reset();
            //enemy.Reset();
            //player.ShowStats();
            //enemy.ShowStats();
            //player.TakeDamage(-10);
            //enemy.Heal(-20);
            //player.RegenShield(-30);
            //player.ShowStats();
            //enemy.ShowStats();
            //showing neither health or shield goes above 100
            //player.Reset();
            //enemy.Reset();
            //player.ShowStats();
            //enemy.ShowStats();
            //player.Heal(100);
            //enemy.RegenShield(100);
            //player.ShowStats();
            //enemy.ShowStats();
        }


    }
}
