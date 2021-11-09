using UnityEngine;

namespace GameComponents
{

    public abstract class ObjectMover<T> : MonoBehaviour
    {
        [SerializeField] internal protected T _direction;

        public abstract void Move();
    }
}
