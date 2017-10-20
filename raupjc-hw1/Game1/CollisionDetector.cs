namespace Game1
{
    public class CollisionDetector
    {
        public static bool Overlaps(IPhysicalObject2D a, IPhysicalObject2D b)
        {
            bool xOverlap = ValueInRange(a.X, b.X, b.X + b.Width) ||
                            ValueInRange(b.X, a.X, a.X + a.Width);

            bool yOverlap = ValueInRange(a.Y, b.Y, b.Y + b.Height) ||
                            ValueInRange(b.Y, a.Y, a.Y + a.Height);

            return xOverlap && yOverlap;
        }
        private static bool ValueInRange(float value, float min, float max)
        { return (value >= min) && (value <= max); }

    }
}