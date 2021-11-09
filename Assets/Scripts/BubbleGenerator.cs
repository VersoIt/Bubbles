using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace GameComponents
{
    public sealed class BubbleGenerator : Generator<Bubble>
    {

        [Header("X coordinate range: ")]
        [SerializeField] private float _xBegin;
        [SerializeField] private float _xEnd;

        [Header("Y coordinate range: ")]
        [SerializeField] private float _yBegin;
        [SerializeField] private float _yEnd;

        [SerializeField] private TextCounter _pointsCounter;

        [Space(5)]
        [SerializeField] private float _fallRateIncreaseFactor;

        public UnityEvent OnObjectCreated;

        private int BubblesCount = 0;

        void Awake() => StartCoroutine(Generate());

        public override Bubble CreateRandomObject(Vector3 position)
        {
            ++BubblesCount;
            OnObjectCreated?.Invoke();

            var element = Instantiate(_objects[Random.Range(0, _objects.Length)], position, Quaternion.identity);
            element.PointsCounter = _pointsCounter;
            element.ForceMover.Acceleration = Mathf.Min(BubblesCount * _fallRateIncreaseFactor + 1, Mathf.Abs(_xEnd - _xBegin));

            return element;
        }

        public override IEnumerator Generate()
        {
            while (true)
            {
                if (_initialCreationSpeed >= 0.28f) _initialCreationSpeed -= 0.02f;
                CreateRandomObject(new Vector2(Random.Range(_xBegin, _xEnd), Random.Range(_yBegin, _yEnd)));
                yield return new WaitForSeconds(_initialCreationSpeed);
            }
        }
    }

}