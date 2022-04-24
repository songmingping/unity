using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : MonoBehaviour
{
    private Transform m_Transform;
    // Start is called before the first frame update
    void Start()
    {
        m_Transform=gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            m_Transform.Translate(Vector3.forward * 0.0250f, Space.World);
        }
        if (Input.GetKey(KeyCode.A))
        {
            m_Transform.Translate(Vector3.left * 0.0250f, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            m_Transform.Translate(Vector3.back * 0.0250f, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            m_Transform.Translate(Vector3.right * 0.0250f, Space.World);
        }
    }

}
