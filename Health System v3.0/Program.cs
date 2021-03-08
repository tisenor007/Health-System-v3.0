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

        //public string playerName;
        //public string enemyName;

        static void Main(string[] args)
        {
            GameManager gameManger = new GameManager();

            //into
            //Console.WriteLine("Welcome to the Health System v3.0.....");
            //Console.WriteLine();
            //small mechanic in the beginning that lets the player choose names for player and enmey in game....
            //Console.WriteLine("What would you like your name to be?");
            //playerName = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Player's name set!");
            //Console.WriteLine();
            //Console.WriteLine("What would you like your Enemies name to be");
            //enemyName = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Enemy's name has been set!");
            //Console.WriteLine();
            //Console.WriteLine("Loading Gameplay.....");
            //Console.WriteLine();
            gameManger.RunGame();
            //sets names
            //player.name = playerName;
            //enemy.name = enemyName;

           


            Console.ReadKey(true);
        }
    }
}
