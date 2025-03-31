// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using MohawkGame2D;

// The namespace your code is in.
namespace MohawkGame2D
{
    internal class render
    {
        Texture2D volcano = Graphics.LoadTexture("../../../assets/volcano.png");
        Texture2D palmtree = Graphics.LoadTexture("../../../assets/palmtree.png");
        Texture2D Attackoptions = Graphics.LoadTexture("../../../assets/Attackoptions.png");
        public void volcanoRender()
        {
            Graphics.Draw(volcano, 150, 0);

        }
        public void palmtreeRender()
        {
            Graphics.Draw(palmtree, 15, 310);
            Graphics.Draw(palmtree, 685, 310);
            
        }
        public void AttackoptionsRender()
        {
            Graphics.Draw(Attackoptions, 0, 150);
        }
           
           
        

    }
}
