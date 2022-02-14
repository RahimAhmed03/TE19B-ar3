﻿using System.Collections;
using System.Numerics;
using System;

namespace Labb_17
{
    public class GameObject
    {
        public bool IsDead { get; set; }
        public Vector2 Position { get; set; }
        public float Radius { get; set; }
        public Vector2 Speed { get; set; }
        public float Rotation { get; set; }

        public bool collideswith(IGameObject other)
        {
            return false;
        }
    }
    public interface IGameObject
    {
    }

    class Meteor : GameObject
    {
        public MeteorType Type { get; set; }
        public float ExplosionScale { get; set; }

        public void Meter(MeteorType type)
        {
            Type = type;
        }
        public void Update(GameTime gamtime)
        {

        }
        public IEnumerable<Meteor> BreakMeteor(Meteor meteor)
        {
            return null;
        }
    }
    public class GameTime
    {
        
    }
}
