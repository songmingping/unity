using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desktrigger : MonoBehaviour
{
    private GameObject[] m_desks;
    // Start is called before the first frame update
    void Start()
    {
        m_desks = GameObject.FindGameObjectsWithTag("Desks");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            deskup();
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            deskdown();
        }
    }
    void deskup()
    {
        for(int i = 0; i < m_desks.Length; i++)
        {
            m_desks[i].GetComponent<Transform>().Translate(Vector3.up * 2, Space.Self);
        }
    }
    void deskdown()
    {
        for (int i = 0; i < m_desks.Length; i++)
        {
            m_desks[i].GetComponent<Transform>().Translate(Vector3.up * -2, Space.Self);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Student")
        {
            deskup();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Student")
        {
            deskdown();
        }
    }
}
