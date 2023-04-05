using System.Numerics;

namespace Physics
{
    public static class UnityPhysicUtils
    {
        public static Vector3 Convert(UnityEngine.Vector3 value)
        {
            return new Vector3(value.x, value.y, value.z);
        }

        public static UnityEngine.Vector3 Convert(Vector3 value)
        {
            return new UnityEngine.Vector3(value.X, value.Y, value.Z);
        }
    }
}