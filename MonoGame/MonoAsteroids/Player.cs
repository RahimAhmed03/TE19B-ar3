using System;
using Microsoft.Xna.Framework;

namespace MonoAsteroids
{
    public class Player : IGameObject
    {
        public bool IsDead { get; set; }
        public Vector2 Position { get; set; }
        public float Radius { get; set; }
        public Vector2 Speed { get; set; }
        public float Rotation { get; set; }
        
    }
}