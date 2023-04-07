using System;
using System.Collections.Generic;
using Entities;
using Transforms;

namespace Physics
{
    public static class PhysicExtension
    {
        public static IEnumerable<IEntity> OverlapCapsule(this IPhysics physics, ICapsule capsule, ITransform transform)
        {
            var localScale = transform.LocalScale;
            return physics.OverlapCapsule(
                transform.Position + capsule.Center,
                capsule.Height * localScale.Y,
                capsule.Radius * Math.Min(localScale.X, localScale.Z),
                transform.Up
            );
        }

        public static IEnumerable<IEntity> OverlapSphere(this IPhysics physics, float radius, ITransform transform)
        {
            var localScale = transform.LocalScale;
            return physics.OverlapSphere(
                transform.Position,
                radius / Math.Min(Math.Min(localScale.X, localScale.Y), localScale.Z)
            );
        }
    }
}