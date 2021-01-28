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
            string Playername;
            string Enemyname;

            //into
            Console.WriteLine("Welcome to the Health System v3.0.....");
            Console.WriteLine();
            //small mechanic in the beginning that lets the player choose names for player and enmey in game....
            Console.WriteLine("What would you like your name to be?");
            Playername = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Player's name set!");
            Console.WriteLine();
            Console.WriteLine("What would you like your Enemies name to be");
            Enemyname = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enemy's name has been set!");
            Console.WriteLine();
            Console.WriteLine("Loading Gameplay.....");
            Console.WriteLine();

            
            Player player = new Player();//instantiation and declaration
            Enemy enemy = new Enemy();//instantiation and declaration

            //sets names
            player.name = Playername;
            enemy.name = Enemyname;

            //Gameplay
            player.Reset();
            enemy.Reset();
            player.ShowStats();
            enemy.ShowStats();
            enemy.TakeDamage(50);
            enemy.ShowStats();
            player.TakeDamage(225);
            player.ShowStats();
            player.TakeDamage(175);
            player.extralife();
            player.ShowStats();
            player.Heal(50);
            player.ShowStats();
            enemy.TakeDamage(25);
            enemy.ShowStats();
            enemy.RegenShield(73);
            enemy.ShowStats();
            player.TakeDamage(115);
            player.ShowStats();
            enemy.TakeDamage(200);
            enemy.ShowStats();
            enemy.Reset();
            enemy.ShowStats();
            player.TakeDamage(230);
            player.ShowStats();
            //shows that nothing accepts negative values
            player.Reset();
            enemy.Reset();
            player.ShowStats();
            enemy.ShowStats();
            player.TakeDamage(-10);
            enemy.Heal(-20);
            player.RegenShield(-30);
            player.ShowStats();
            enemy.ShowStats();
            //showing neither health or shield goes above 100
            player.Reset();
            enemy.Reset();
            player.ShowStats();
            enemy.ShowStats();
            player.Heal(100);
            enemy.RegenShield(100);
            player.ShowStats();
            enemy.ShowStats();


            Console.ReadKey(true);
        }
    }
}
