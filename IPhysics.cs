using System.Collections.Generic;
using System.Numerics;
using Entities;

namespace Physics
{
    public interface IPhysics
    {
        IEnumerable<IEntity> OverlapSphere(Vector3 position, float radius);
    }
}