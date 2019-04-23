using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdminScript : MonoBehaviour
{
    public bool isAlive = false;
    public int coinCount = 0; 
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player);
        isAlive = true;
        Debug.Log(isAlive);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isAlive)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(player);
                isAlive = true;
            }
        }
    }
}
