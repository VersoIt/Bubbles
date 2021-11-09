using UnityEngine;
using System.Collections;

namespace GameComponents
{
    public abstract class Generator<T> : MonoBehaviour
    {
        [SerializeField] internal protected T[] _objects;

        [SerializeField] internal protected float _initialCreationSpeed;

        public abstract T CreateRandomObject(Vector3 position);

        public virtual IEnumerator Generate()
        {
            while (true)
            {
                yield return new WaitForSeconds(_initialCreationSpeed);
                CreateRandomObject(Vector3.zero);
            }
        }
    }
}
