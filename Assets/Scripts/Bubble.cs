using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameComponents
{
    [RequireComponent(typeof(ForceMover))]
    public class Bubble : EnemyObject, IExplodable
    {
        [SerializeField] private GameObject _explodingParticle;

        public TextCounter PointsCounter { get; set; }

        public ForceMover ForceMover { get; set; }

        private void Awake() => ForceMover = GetComponent<ForceMover>();

        public void OnMouseDown()
        {
            if (!GameController.IsGamePaused())
            {
                PointsCounter += _damage;
                Explode();

                AudioSource.PlayClipAtPoint(_sound, transform.position);
                OnDestroyed?.Invoke();

                Destroy(gameObject);
            }
        }

        public void Explode() => Instantiate(_explodingParticle, gameObject.transform.position, Quaternion.identity);

        private void FixedUpdate() => ForceMover.Move();
        }

    }