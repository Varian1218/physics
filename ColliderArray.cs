using UnityEngine;

namespace Physics
{
    [CreateAssetMenu(menuName = "Colliders/Colliders", fileName = "Colliders", order = 1)]
    public class ColliderArray : ScriptableObject
    {
        public int Size
        {
            set => Values = new Collider[value];
        }

        public Collider[] Values { get; set; }
    }
}