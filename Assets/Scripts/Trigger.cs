using UnityEngine.Events;
using UnityEngine;

namespace GameComponents
{
    class Trigger : MonoBehaviour
    {
        public UnityEvent OnGameLosed;

        public void StartTrigger(int value) => OnGameLosed?.Invoke();

        public void TryStartTrigger(int value)
        {
            if (value <= 0) StartTrigger(value);
        }
    }
}
