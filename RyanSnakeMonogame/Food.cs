using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanSnakeMonogame
{
    public class Food
    {
        public Vector2 position;
        public Texture2D texture;
       public  Color tint;
        public Rectangle hitbox;
                     
        public Food(Vector2 position, Texture2D texture, Color tint)
        {
            this.position = position;
            this.texture = texture;
            this.tint = tint;
            hitbox = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            
            spriteBatch.Draw(texture, position, tint);
        }
        public void Move()
        {
            int random = new Random().Next(0, 500);
            int random2 = new Random().Next(0, 500);
            position.X = random;
            position.Y = random2;
            hitbox.X = random;
            hitbox.Y = random2;
        }
        }
}
