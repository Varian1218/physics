using UnityEngine;
using Vector3 = System.Numerics.Vector3;

namespace Physics
{
    public class Capsule : ICapsule
    {
        private CapsuleCollider _impl;

        public CapsuleCollider Impl
        {
            set => _impl = value;
        }

        public Vector3 Center => UnityPhysicUtils.Convert(_impl.center);
        public float Height => _impl.height;
        public float Radius => _impl.radius;
    }
}