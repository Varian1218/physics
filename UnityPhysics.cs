using System.Collections.Generic;
using System.Linq;
using Entities;
using UnityEngine;
using UnityVector3 = UnityEngine.Vector3;
using Vector3 = System.Numerics.Vector3;

namespace Physics
{
    public class UnityPhysics : IPhysics
    {
        private Collider[] _colliders;
        private GameObjectEntity[] _entities;

        public int Size
        {
            set
            {
                _colliders = new Collider[value];
                _entities = new GameObjectEntity[value];
                for (var i = 0; i < value; i++)
                {
                    _entities[i] = new GameObjectEntity();
                }
            }
        }

        private static UnityVector3 Convert(Vector3 value)
        {
            return new UnityVector3(value.X, value.Y, value.Z);
        }

        public IEnumerable<IEntity> OverlapCapsule(Vector3 a, Vector3 b, float radius)
        {
            var length = UnityEngine.Physics.OverlapCapsuleNonAlloc(Convert(a), Convert(b), radius, _colliders);
            for (var i = 0; i < length; i++)
            {
                _entities[i].Impl = _colliders[i].gameObject;
            }

            return _entities.Take(length);
        }

        public IEnumerable<IEntity> OverlapSphere(Vector3 position, float radius)
        {
            var length = UnityEngine.Physics.OverlapSphereNonAlloc(Convert(position), radius, _colliders);
            for (var i = 0; i < length; i++)
            {
                _entities[i].Impl = _colliders[i].gameObject;
            }

            return _entities.Take(length);
        }
    }
}