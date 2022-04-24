using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Transform m_transform;
    // Start is called before the first frame update
    void Start()
    {
        m_transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Open();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Close();
        }
    }
    public void Open()
    {
        m_transform.Rotate(Vector3.up, 90);
    }
    public void Close()
    {
        m_transform.Rotate(Vector3.up, -90);
    }
}
