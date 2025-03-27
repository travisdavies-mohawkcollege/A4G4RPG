using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MohawkGame2D;

namespace Group4_a4_RPGBattle
{
    internal class Player
    {
        public int playerChoice = 0;
        // 0 is Fire, 1 is Grass, 2 is Water
        public int attackElement;
        public void PlayerControl()
        {
            if (Input.IsKeyboardKeyPressed(KeyboardInput.One))
            {
                playerChoice = 1;
                attackElement = 0;
            }
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Two))
            {
                playerChoice = 2;
                attackElement = 1;
            }
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Three))
            {
                playerChoice = 3;
                attackElement = 2;
            }
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Four))
            {
                playerChoice = 4;
            }
        }

        public void ChoiceRender()
        {
            if (playerChoice == 1)
            {
                Draw.FillColor = Color.Yellow;
                Draw.Quad(0, 400, 400, 400, 400, 500, 0, 500);
            }
            if (playerChoice == 2)
            {
                Draw.FillColor = Color.Yellow;
                Draw.Quad(400, 400, 800, 400, 800, 500, 400, 500);
            }
            if (playerChoice == 3)
            {
                Draw.FillColor = Color.Yellow;
                Draw.Quad(0, 500, 400, 500, 400, 600, 0, 600);
            }
            if (playerChoice == 4)
            {
                Draw.FillColor = Color.Yellow;
                Draw.Quad(400, 500, 800, 500, 800, 600, 400, 600);
            }
        }

    }
}
