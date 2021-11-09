using UnityEngine;
using UnityEngine.Events;

namespace GameComponents
{

    public class BoundingObject : MonoBehaviour
    {
        public UnityEvent OnDestroyed;

        private void OnCollisionEnter(Collision collision)
        {
            OnDestroyed?.Invoke();

            IExplodable explodable = collision.gameObject.GetComponent<MonoBehaviour>() as IExplodable;
            explodable?.Explode();

            Destroy(collision.gameObject);
        }
    }

}
