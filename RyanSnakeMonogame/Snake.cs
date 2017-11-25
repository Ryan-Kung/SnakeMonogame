using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanSnakeMonogame
{
    public class Snake
    {
        Vector2 position;
        Texture2D texture;
        Color tint;
        public int xSpeed;
        public int ySpeed;
        public Rectangle hitbox;

        public Snake(Vector2 position, Texture2D texture, Color tint, int xSpeed = 2, int ySpeed = 2)
        {
            this.position = position;
            this.texture = texture;
            this.tint = tint;
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
            hitbox = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, tint);
        }
        public void Move(GameTime gameTime, KeyboardState ks, int Screenwidth)
        {
            if(ks.IsKeyDown(Keys.Left))
            {
                position.X -= xSpeed;
            }
            if(ks.IsKeyDown(Keys.Right))
            {
                position.X += xSpeed;
            }
            if(ks.IsKeyDown(Keys.Up))
            {
                position.Y -= ySpeed;
            }
            if(ks.IsKeyDown(Keys.Down))
            {
                position.Y += ySpeed;
            }
                }
    }
}
