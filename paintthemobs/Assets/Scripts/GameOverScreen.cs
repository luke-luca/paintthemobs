using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject DeathCanvas;
    private void Start()
    {
        gameObject.SetActive(false);
    }
    public void ShowScreen()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Init");
        Time.timeScale = 1;
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
