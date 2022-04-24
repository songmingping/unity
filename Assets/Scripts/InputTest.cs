using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("GetKey:A");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("GetKeyDown:W");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Getmouseleft");
        }
    }
}
