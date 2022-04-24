using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doortigger : MonoBehaviour
{
    private Door m_door;
    // Start is called before the first frame update
    void Start()
    {
        m_door=GameObject.Find("Door father").GetComponent<Door>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Student")
        {
            m_door.Open();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Student")
        {
            m_door.Close();
        }
    }
}
