using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int Score = 0;
    public Text scoreText;
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void RestartGame()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);

        // Carrega a cena inicial
        SceneManager.LoadScene(0);
    }
}
