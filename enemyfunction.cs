// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    class enemyfunction
    {
        public int enemyChoice;
        public bool enemyBlock = false;

        public void enemyAttack()
        {
                enemyChoice = Random.Integer(4);
                if (enemyChoice == 0)
                {
                    Console.WriteLine("Enemy used Flame attack!");
                }
                if (enemyChoice == 1)
                {
                    Console.WriteLine("Enemy used Leaf attack!");
                }
                if (enemyChoice == 2)
                {
                    Console.WriteLine("Enemy used Water attack!");
                }
                if (enemyChoice == 3)
                {
                    Console.WriteLine("Enemy Chose to block!");
                }
            }
    }
}
