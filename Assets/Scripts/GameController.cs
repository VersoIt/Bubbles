using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

namespace GameComponents
{
    class GameController : MonoBehaviour
    {

        public UnityEvent OnGameStarted;

        private void Awake() => OnGameStarted?.Invoke();

        public static void PauseGame() => Time.timeScale = 0;

        public static void ResumeGame() => Time.timeScale = 1;

        public static void TryPauseGame()
        {
            if (Time.timeScale == 1) PauseGame();
            else ResumeGame();
        }

        public static bool IsGamePaused() => Time.timeScale == 0;

        public static void RestartGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
