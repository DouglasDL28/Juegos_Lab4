using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PausedMenu : MonoBehaviour
{
    private bool isPaused = false;


    private void Start()
    {
        transform.Find("PauseMenu").gameObject.SetActive(false);
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Continue();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        transform.Find("PauseMenu").gameObject.SetActive(true);
        Time.timeScale = 0.0f;
        isPaused = true;
    }

    public void Continue()
    {
        transform.Find("PauseMenu").gameObject.SetActive(false);
        Time.timeScale = 1.0f;
        isPaused = false;
    }

    public void HacerAlgo()
    {
        transform.Find("HacerAlgo").Find("Text").GetComponent<Text>().text = "Hice Algo";
    }

    public void CambiarEscena(string newScene)
    {
        SceneManager.LoadScene(newScene);
    }
}
