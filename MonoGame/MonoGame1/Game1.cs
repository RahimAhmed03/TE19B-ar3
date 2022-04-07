using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Vector2 = Microsoft.Xna.Framework.Vector2;

namespace MonoGame1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private Texture2D normalTexture;
        private Texture2D jumpingTexture;
        private Texture2D crouchTexture;
        private Texture2D fireballTexture;
        private Texture2D currentTexture;
        private SpriteFont font;

        private List<Vector2> fireballs;
        private int fireballTimer = 120;
        private Random rnd;

        private Vector2 position;
        private Vector2 speed;
        private bool isJumping;
        private bool isCrouching;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            position = new Vector2(300, 200);
            fireballs = new List<Vector2>();
            rnd = new Random();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            normalTexture = Content.Load<Texture2D>("normal");
            jumpingTexture = Content.Load<Texture2D>("jump");
            crouchTexture = Content.Load<Texture2D>("crouch");
            fireballTexture = Content.Load<Texture2D>("fireball");
            font = Content.Load<SpriteFont>("font");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            position += speed;
            if (position.Y > 200)
            {
                position = new Vector2(position.X, 200);
                speed = Vector2.Zero;
                isJumping = false;
            }
            speed += new Vector2(0, 0.2f);

            var state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.W) && !isJumping)
            {
                speed = new Vector2(0, -5.0f);
                isJumping = true;
            }
            if (state.IsKeyDown(Keys.S) && !isJumping)
            {
                isCrouching = true;
            }
            else
            {
                isCrouching = false;
            }

            //fireballs!!
            fireballTimer--;
            if (fireballTimer <= 0)
            {
                fireballTimer = 120;
                if (rnd.Next(2) == 0)
                {
                    fireballs.Add(new Vector2(800, 200));
                }
                else
                {
                    fireballs.Add(new Vector2(800, 240));
                }
            }

            for (int i = 0; i < fireballs.Count; i++)
            {
                fireballs[i] = fireballs[i] + new Vector2(-2, 0);
            }

            //collision
    
            if (isJumping)
            {
                currentTexture = jumpingTexture;
            }
            else if (isCrouching)
            {
                currentTexture = crouchTexture;
            }
            else
            {
                currentTexture = normalTexture;
            }

           /*  Rectangle playerBox = new Rectangle((int)position.X, (int)position.Y, 48, 60);
            Rectangle meteorBox = new Rectangle((int)meteorX, (int)meteorY, 110, 110);

            //Överlappar vi?
            kollision = Intersection(playerBox, meteorBox);

            if (kollision.Width > 0 && kollision.Height > 0)
            {
                Rectangle r1 = Normalize(playerBox, kollision);
                Rectangle r2 = Normalize(meteorBox, kollision);
                bHit = TestCollision(ship, r1, meteor, r2);
            }
            else
                bHit = false; */

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.DrawString(font, ((int)gameTime.TotalGameTime.TotalSeconds).ToString(), new Vector2(10, 20), Color.White);

            spriteBatch.Draw(currentTexture, position, Color.White);


            foreach (var fireball in fireballs)
            {
                spriteBatch.Draw(fireballTexture, fireball, Color.White);

            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
