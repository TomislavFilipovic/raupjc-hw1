

using System.Runtime.Remoting.Messaging;
using Microsoft.Xna.Framework;

namespace Game1
{
    public class GameVector
    {
        private Vector2 vector;

        public Direction BallDirection { get; private set; }

        public enum Direction
        {
            UpLeft,UpRight,DownLeft,DownRight
        }

        public GameVector(Direction direction)
        {
            BallDirection = direction;
            switch (direction)
            {
                case Direction.DownLeft:
                    vector=new Vector2(-1,1);
                    break;
                case Direction.DownRight:
                    vector = new Vector2(1, 1);
                    break;
                case Direction.UpLeft:
                    vector = new Vector2(-1, -1);
                    break;
                case Direction.UpRight:
                    vector = new Vector2(1,- 1);
                    break;
            }
        }

        public static Vector2 operator *(GameVector vector1, Vector2 vector2)
        {
            return new Vector2(vector1.vector.X * vector2.X, vector1.vector.Y * vector2.Y);
        }
        public static Vector2 operator *(GameVector vector1, float vector2)
        {
            return new Vector2(vector1.vector.X * vector2, vector1.vector.Y * vector2);
        }
    }

}