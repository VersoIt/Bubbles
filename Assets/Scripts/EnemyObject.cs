using UnityEngine;
using UnityEngine.Events;

namespace GameComponents
{
    public class EnemyObject : MonoBehaviour
    {
        [SerializeField] internal protected int _damage;

        [SerializeField] internal protected AudioClip _sound;

        public UnityEvent OnDestroyed;

        public int Damage
        {
            get => _damage;
        }
    }
}
