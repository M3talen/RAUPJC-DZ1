﻿using Microsoft.Xna.Framework;

namespace Pong
{
    /// <summary >
    /// Game  ball  object  representation
    /// </summary >
    public class Ball : Sprite
    {
        private float _speed;

        /// <summary >
        /// Defines  current  ball  speed in time.
        ///  </summary >
        public float Speed
        {
            get { return _speed; }
            set { _speed = value > GameConstants.MaxBallSpeed ? GameConstants.MaxBallSpeed : value; }
        }
        
        public float BumpSpeedIncreaseFactor { get; set; }

        /// <summary >
        /// Defines  ball  direction.
        /// Valid  values (-1,-1), (1,1), (1,-1), (-1,1).
        /// Using  Vector2  to  simplify  game  calculation. Potentially
        /// dangerous  because  vector 2 can  swallow  other  values  as well.
        /// OPTIONAL TODO: create  your own , more  suitable  type
        /// </summary >
        public Vector2 Direction { get; set; }

        public Ball(int size, float speed, float defaultBallBumpSpeedIncreaseFactor) : base(size, size)
        {
            Speed = speed;
            BumpSpeedIncreaseFactor = defaultBallBumpSpeedIncreaseFactor;
            //  Initial  direction
            Direction = new Vector2(1, 1);
        }
    }
}