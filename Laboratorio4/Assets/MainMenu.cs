using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Libreria para usar el menú.

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CambiarEscena(string newScene)
    {
        SceneManager.LoadScene(newScene);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
