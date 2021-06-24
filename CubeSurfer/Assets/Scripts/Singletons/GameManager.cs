using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Singletons
{
    public class GameManager : SingletonSetup<GameManager>
    {
        public event System.Action EventGameOver;

        void Awake()
        {
            Setup(this);
        }
        public void StopGame()
        {
            Time.timeScale = 0;
        }
        public void ResumeGame()
        {
            Time.timeScale = 1;
        }
        public void GameOver()
        {
            StopGame();
            Debug.Log("Ölüm gerçekleþti");
            EventGameOver?.Invoke();
        }

    }

}
