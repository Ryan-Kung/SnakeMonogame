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
    enum Direction
    {
        None,
        Up,
        Down,
        Left,
        Right
    }

    public class Snake
    {
        public Vector2 position;
        Texture2D texture;
        Color tint;
        public int xSpeed;
        public int ySpeed;
        public Rectangle hitbox;
        Direction direction = Direction.None;

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
        public void HeadMove(KeyboardState ks)
        {
           if(ks.IsKeyDown(Keys.Right))
            {
                direction = Direction.Right;
            }
            if (ks.IsKeyDown(Keys.Left))
            {
                direction = Direction.Left;

            }
            
            if (ks.IsKeyDown(Keys.Up))
            {
                direction = Direction.Up;
               
            }
            if (ks.IsKeyDown(Keys.Down))
            {
                direction = Direction.Down;
            }
        }
        public void Move()
        {
            if(direction == Direction.Up)
            {
                position.Y -= texture.Height;
            }
            if(direction == Direction.Down)
            {
                position.Y += texture.Height;
            }
            if(direction == Direction.Left)
            {
                position.X -= texture.Width;
            }
            if(direction == Direction.Right)
            {
                position.X += texture.Width;
            }
        }
        
    }
}
