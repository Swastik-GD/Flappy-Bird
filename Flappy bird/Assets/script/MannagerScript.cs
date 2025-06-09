using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MannagerScript : MonoBehaviour
{

    public int playerscore = 0;
    public Text score;
    public GameObject GameOverScreen;
    public AudioSource DingSFX;
    public GameObject StartScreen;

    [ContextMenu("Increase score")]
    public void AddScore(int scoreToAdd)
    {
        playerscore = playerscore + scoreToAdd;
        score.text = playerscore.ToString();
        DingSFX.Play();
    }

    public void Awake()
    {
        Pause();
    }

    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void gameOver()
    {
        GameOverScreen.SetActive(true);
        Pause();
    }

    public void Playgame()
    {
        StartScreen.SetActive(false);
        Time.timeScale = 1f;
    }

}
