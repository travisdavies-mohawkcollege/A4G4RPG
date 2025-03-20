// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    class enemyfunction
    {
        Game game;
        
        public void enemyAttack()
        {
            game = new Game();
            game.enemyChoice = Random.Integer(3);
        }
    }
}
