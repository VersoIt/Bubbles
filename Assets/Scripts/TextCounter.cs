using UnityEngine;
using UnityEngine.UI;

namespace GameComponents
{
    public class TextCounter : MonoBehaviour, ICountable
    {
        [SerializeField] internal protected Text _countText;

        [SerializeField] internal protected string _title;

        [SerializeField] internal protected int _count;

        public virtual int Count
        {
            get => _count;
            set
            {
                _count = Mathf.Max(value, 0);
                _countText.text = $"{_title}{_count}";
            }
        }

        public static TextCounter operator -(TextCounter count, int value)
        {
            count.Count -= value;
            return count;
        }

        public static TextCounter operator +(TextCounter count, int value)
        {
            count.Count += value;
            return count;
        }
    }
}
