using System.Numerics;

namespace Physics
{
    public interface ICapsule
    {
        public Vector3 Center { get; }
        public float Height { get; }
        public float Radius { get; }
    }
}