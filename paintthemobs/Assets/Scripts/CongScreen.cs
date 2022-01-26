using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongScreen : MonoBehaviour
{
    public GameObject CongCanvas;
    private void Start()
    {
        gameObject.SetActive(false);
    }
    public void ShowEndScreen()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
