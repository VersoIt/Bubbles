using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace GameComponents
{
    public class HealthDecreator : TextCounter
    {
        #region Inspector args
        [SerializeField] private string _tag;

        public UnityEvent OnNoneHealth;
        #endregion

        const int None = 0;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == _tag)
                Count -= collision.gameObject.GetComponent<Bubble>().Damage;

            if (Count == None) OnNoneHealth?.Invoke();
        }
    }

}