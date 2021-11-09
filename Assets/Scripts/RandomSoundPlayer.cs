using UnityEngine;

namespace GameComponents
{
    class RandomSoundPlayer : MonoBehaviour
    {
        [SerializeField] private AudioSource _audioSource;

        [SerializeField] private AudioClip[] _audioClips;

        public void PlayRandomSound() => 
            _audioSource.PlayOneShot(_audioClips[Random.Range(0, _audioClips.Length)]);
    }
}
