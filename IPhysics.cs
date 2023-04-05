using System.Collections.Generic;
using System.Numerics;
using Entities;

namespace Physics
{
    public interface IPhysics
    {
        IEnumerable<IEntity> OverlapCapsule(Vector3 a, Vector3 b, float radius);
        IEnumerable<IEntity> OverlapSphere(Vector3 position, float radius);
    }
}