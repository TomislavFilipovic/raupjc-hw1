using System;
using Microsoft.Xna.Framework;

namespace Game1
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
        public float Speed {
            get =>_speed; 
            set=>_speed=Math.Min(value,1f); }
        
        public float BumpSpeedIncreaseFactor { get; set; }
        /// <summary >
        /// Defines  ball  direction.
        /// Valid  values (-1,-1), (1,1), (1,-1), (-1,1).
        /// Using  Vector2  to  simplify  game  calculation. Potentially
        /// dangerous  because  vector 2 can  swallow  other  values  as well.
        ///  </summary >
        public GameVector Direction { get; set; }
        public Ball(int size, float speed, float
            defaultBallBumpSpeedIncreaseFactor) : base(size, size)
        {
            Speed = speed;
            BumpSpeedIncreaseFactor = defaultBallBumpSpeedIncreaseFactor;
            //  Initial  direction
            Direction = new GameVector(GameVector.Direction.DownRight);
        }
    }
}