using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Classes Explained:");

            // before classes

            // player

            int x = 0;
            int y = 0;
            int health = 100;
            int shield = 100;

            // enemy

            int enemy1X = 10;
            int enemy1Y = 10;

            // enemy 2
            int enemy2X = 20;
            int enemy2Y = 20;

            // enemies
            int numEnemies = 20;
            int[] enemyX = new int[numEnemies];
            int[] enemyY = new int[numEnemies];
            for (int i = 0; i <= numEnemies -1; i++)
            {
                enemyX[i] = i;
                enemyY[i] = i;
            }


            Console.WriteLine("Player: (" + x + "," + y + ")");
            Console.WriteLine("Enemy: (" + enemy1X + "," + enemy1Y + ")");

            for (int i = 0; i <= numEnemies -1; i++)
            {
                Console.WriteLine("Enemy: [" + i + "]: " + "(" + enemyX[i] + "," + enemyY[i] + ")");
            }


            // using classes
            Player player1 = new Player();
            player1.x = 20;
            player1.y = 20;


            Enemy enemy1 = new Enemy();
            Console.WriteLine("Enemy: (" + enemy1.x + "," + enemy1.y + ")");
            Console.ReadKey(true);
        }
    }

}
