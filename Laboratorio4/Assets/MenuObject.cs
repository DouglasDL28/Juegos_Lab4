using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuObject : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
        OnMouseDown();
        }

        OnMouseEnter();
       

    }

    private void OnMouseDown()
    {
    
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 100.0f))
        {
            if(hit.rigidbody != null && hit.rigidbody == rb)
            {
                hit.rigidbody.AddForce(-hit.normal * 200f);
            }
        }
    }

    private void OnMouseEnter()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 100.0f))
        {
            if (hit.rigidbody != null && hit.rigidbody == rb)
            {
                changeColor();
            }
        }

        void changeColor()
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

}
