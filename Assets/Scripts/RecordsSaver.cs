using UnityEngine;

namespace GameComponents
{
    public class RecordsSaver : MonoBehaviour
    {
        public static void Save(TextCounter element) => 
            PlayerPrefs.SetInt(nameof(element), Mathf.Max(PlayerPrefs.GetInt(nameof(element)), element.Count));


        public static void Load(TextCounter element) => element.Count = PlayerPrefs.GetInt(nameof(element));

    }
}
