// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        // Variables to track player and enemy, as well as game state. Gamestate 0 is setup, 1 is player turn, 2 is enemy turn, 3 is player win, 4 is enemy win, 5 is total victory.
        int enemyHP;
        int playerHP;
        int playerDamage;
        int enemyDamage;
        int gameState;
        int playerChoice;
        int enemyChoice;
        bool playerBlock;
        bool enemyBlock;
        int currentEnemy;


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Group 4 RPG Battle");

            enemyHP = 150;
            playerHP = 100;
            gameState = 0;
            currentEnemy = 0;

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            //add all draw calls to the draw function
            Draw();

            if (gameState == 0)
            {
                currentEnemy++;
                enemyHP = 150;
                playerHP = 100;
                gameState = 1;
            }
            if (gameState == 1)
            {
                PlayerTurn();
            }
            if (gameState == 2)
            {
                EnemyTurn();
            }
            if (gameState == 3)
            {
                //Player wins, add victory text here if wanted, then go to next enemy.
                gameState = 0;
            }
            if (gameState == 4)
            {
                //Enemy wins, add defeat text here if wanted, then go to first enemy.
                currentEnemy = 0;
                gameState = 0;
            }

        }


        public void Draw()
        {
            //draw background
            //draw menus
            //draw player and enemy
            if (currentEnemy == 1)
            {
                //draw enemy 1
            }
            if (currentEnemy == 2)
            {
                //draw enemy 2
            }
            if (currentEnemy == 3)
            {
                //draw enemy 3
            }
            //draw health bars
            //draw text
            //draw player and enemy moves
        }

        public void PlayerTurn()
        {
            //Player Turn
            if (playerHP > 0)
            {
                if (Input.IsKeyboardKeyPressed(KeyboardInput.Enter))
                {
                    //Call player attack function.
                    //After player presses enter, the game checks selected move and applies damage to enemy. 
                    if (playerChoice == 1)
                    {
                        playerDamage = 10;
                        enemyHP -= playerDamage;
                    }
                    if (playerChoice == 2)
                    {
                        playerDamage = 10;
                        enemyHP -= playerDamage;
                    }
                    if (playerChoice == 3)
                    {
                        playerDamage = 10;
                        enemyHP -= playerDamage;
                    }
                    if (playerChoice == 4)
                    {
                        playerBlock = true;
                    }
                    gameState = 2;

                }

            }
            else
            {
                //If player has no health, enemy wins.
                gameState = 4;
            }
        }
        
        public void EnemyTurn()
        {
            if (enemyHP > 0)
            {
                //Enemy Turn
                //Call enemy attack function, which will check which move the enemy chose and apply the appropriate damage.

                if (enemyChoice == 1)
                {
                    enemyDamage = 10;
                    enemyHP -= enemyDamage;
                }
                if (enemyChoice == 2)
                {
                    enemyDamage = 10;
                    enemyHP -= enemyDamage;
                }
                if (enemyChoice == 3)
                {
                    enemyDamage = 10;
                    enemyHP -= enemyDamage;
                }
                if (enemyChoice == 4)
                {
                    enemyBlock = true;
                }
                gameState = 1;
            }
            else
            {
                //If enemy has no health, player wins.
                gameState = 3;
            }
        }

    }


}
