using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public void PlayButton()
    {
        SceneManager.LoadScene("Init");
        Time.timeScale = 1;
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
