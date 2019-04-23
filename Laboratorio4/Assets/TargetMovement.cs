using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public float speed = 2f;
    Vector3 tempPos = new Vector3();

    private void Start()
    {
        tempPos = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        tempPos.y = 1 + Mathf.PingPong(Time.time * speed, 2);
        transform.position = tempPos;
    }

}
