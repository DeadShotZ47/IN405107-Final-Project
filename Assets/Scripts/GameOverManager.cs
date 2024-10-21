using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public AudioSource backgroundMusic;
    public AudioSource deathSound;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
        StopBackgroundMusic();
        PlayDeathSound();
    }

    private void StopBackgroundMusic()
    {
        if (backgroundMusic.isPlaying)
        {
            backgroundMusic.Stop();
        }
    }

    private void PlayDeathSound()
    {
        if (deathSound != null)
        {
            deathSound.Play();
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
