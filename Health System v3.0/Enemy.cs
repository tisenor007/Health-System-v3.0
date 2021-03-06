﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Health_System_v3._0
{
    class Enemy : GameCharacter
    {
        public Enemy()//string enemyName)
        {
            name = "Darth Vader";
            //name = enemyName;
            health = 100;
            shield = 100;
            //no enemy has more than 1 life, that would be unfair to player....
            lives = 1;
        }
        public bool UnitTest()
        {
            Reset();

            ShowStats();
            TakeDamage(50);
            Debug.Assert(shield == 50);
            ShowStats();
            return UnitTest();
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
