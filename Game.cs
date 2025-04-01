// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using Group4_a4_RPGBattle;

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
        int enemyDamage = 25;
        int gameState;
        int playerChoice;
        bool playerBlock;
        int currentEnemy;
        // 0 is Fire, 1 is Grass, 2 is Water
        int attackElement;
        int enemyDefenseElement;
        //calling classes
        EnemyFunction enemyAttackFunction;
        render render ;
        Player player;


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Group 4 RPG Battle");
            // setting names of classes
            enemyAttackFunction = new EnemyFunction();
            render = new render();
            player = new Player();
            //Stats
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
            player.PlayerControl();
            //add all draw calls to the draw function
            Render();
            
            if (gameState == 0)
            {
                currentEnemy++;
                if(currentEnemy == 4)
                {
                    gameState = 5;
                }
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
                
            }

        }


        public void Render()
        {
            //draw background
            Window.ClearBackground(Color.Gray);

            //draw menus
            //draw player and enemy
            Draw.FillColor = Color.Yellow;
            Draw.Circle(100, 200, 50);
            if (currentEnemy == 1)
            {
                Draw.Triangle(680, 200, 740, 200, 710, 140);
            }
            if (currentEnemy == 2)
            {
                Draw.Rectangle(600, 150, 150, 75);
            }
            if (currentEnemy == 3)
            {
                
                Draw.Square(650, 150, 100);
            }
            if(gameState == 4)
            { 
                Text.Size = 50;
                Text.Color = Color.Red;
                Text.Draw("You Lose!", 400, 300);
            }
            if (gameState == 5)
            {
                Text.Color = Color.Green;
                Text.Size = 50;
                Text.Draw("You Win!", 400, 300);
            }
            else
            {
                
                player.ChoiceRender();
                render.volcanoRender();
                render.palmtreeRender();
                render.AttackoptionsRender();
                PlayerHealthBar();
                EnemyHealthBar();
            }

        }

        public void PlayerTurn()
        {
            //Player Turn
            if (playerHP > 0)
            {
                if (Input.IsKeyboardKeyPressed(KeyboardInput.Enter))
                {
                    //Call player attack function.
                    playerChoice = player.playerChoice;
                    attackElement = player.attackElement;

                    //After player presses enter, the game checks selected move and applies damage to enemy. 
                    if (playerChoice == 4)
                    {
                        PlayerDamageCalculator();
                        enemyHP -= playerDamage;
                        Console.WriteLine("Player used attack 1");
                    }
                    if (playerChoice == 2)
                    {
                        PlayerDamageCalculator();
                        enemyHP -= playerDamage;
                        Console.WriteLine("Player used attack 2");
                    }
                    if (playerChoice == 3)
                    {
                        PlayerDamageCalculator();
                        enemyHP -= playerDamage;   
                        Console.WriteLine("Player used attack 3");
                    }
                    if (playerChoice == 1)
                    {
                        playerBlock = true;
                        Console.WriteLine("Player chose to block!");
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
                enemyAttackFunction.enemyAttack();
                if (enemyAttackFunction.enemyChoice == 0)
                {
                    //testing text can be swapped with moves
                    EnemyDamageCalculator();
                    playerHP -= enemyDamage;
                }
                if (enemyAttackFunction.enemyChoice == 1)
                {
                    //testing text can be swapped with moves
                    EnemyDamageCalculator();
                    playerHP -= enemyDamage;
                }
                if (enemyAttackFunction.enemyChoice == 2)
                {
                    //testing text can be swapped with moves
                    EnemyDamageCalculator();    
                    playerHP -= enemyDamage;
                }
                if (enemyAttackFunction.enemyChoice == 3)
                {
                    //testing text can be swapped with moves
                    playerDamage = playerDamage / 2;
                    /*enemyAttackFunction.enemyBlock = true;*/
                }
                gameState = 1;
            }
            else
            {
                //If enemy has no health, player wins.
                gameState = 3;
            }
        }

        public void PlayerDamageCalculator()
        {
            //Calculate damage dealt to player and enemy based on moves chosen.
            // 0 is Fire, 1 is Grass, 2 is Water
            if (attackElement == 0)
            {
                if (enemyDefenseElement == 0)
                {
                    playerDamage = 50;
                }
                if (enemyDefenseElement == 1)
                {
                    playerDamage = 75;
                    //print "It's super effective!"
                }
                if (enemyDefenseElement == 2)
                {
                    playerDamage = 25;
                    //print "It's not very effective..."
                }
            }
            if (attackElement == 1)
            {
                if (enemyDefenseElement == 0)
                {
                    playerDamage = 25;
                    //print "It's not very effective..."
                }
                if (enemyDefenseElement == 1)
                {
                    playerDamage = 50;
                }
                if (enemyDefenseElement == 2)
                {
                    playerDamage = 75;
                    //print "It's super effective!"
                }
            }
            if (attackElement == 2)
            {
                if (enemyDefenseElement == 0)
                {
                    playerDamage = 75;
                    //print "It's super effective!"
                }
                if (enemyDefenseElement == 1)
                {
                    playerDamage = 25;
                    //print "It's not very effective..."
                }
                if (enemyDefenseElement == 2)
                {
                    playerDamage = 50;
                }
            }
            //if (enemyAttackFunction.enemyBlock == true)
            //{
            //    playerDamage = playerDamage / 2;
            //    //print "Enemy blocked your attack!"
            //}
        }

        public void EnemyDamageCalculator()
        {
            //if giving a player an element, add weaknesses here.
            if (playerBlock == true)
            {
                enemyDamage = enemyDamage / 2;
                //print "You blocked enemy's attack!"
                playerBlock = false;
            }
        }
        public void PlayerHealthBar()
        {
            Draw.FillColor = Color.Gray;
            Draw.Rectangle(20, 20, 100, 20);
            Draw.FillColor = Color.Red;
            Draw.Rectangle(20, 20, playerHP, 20);
            if (Input.IsKeyboardKeyPressed(KeyboardInput.F))
            {
                playerHP = 50;
            }
        }
        public void EnemyHealthBar()
        {
            Draw.FillColor = Color.Gray;
            Draw.Rectangle(600, 20, 150, 20);
            Draw.FillColor = Color.Red;
            Draw.Rectangle(600, 20, enemyHP, 20);
            if (Input.IsKeyboardKeyPressed(KeyboardInput.G))
            {
                enemyHP = 50;
            }
        }
    }


}
