//Health System v3.0
//Trenton Isenor
//Created: Jan, 21, 2021
//Introductionn to Object Oriented Programming 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Health System v3.0.....");
            Console.WriteLine();

            Player player = new Player();
            Enemy enemy = new Enemy();

            player.ShowStats();
            Console.WriteLine();
            enemy.ShowStats();

            enemy.TakeDamage(220);
            Console.WriteLine();
            enemy.ShowStats();
            enemy.Reset();
            enemy.ShowStats();

            Console.ReadKey(true);
        }
    }
}
