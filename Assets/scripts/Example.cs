using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    public int testNumber = 5;
    public GameObject camera1;
    public GameObject camera2;
    void Start()
    {
        Debug.Log("testNumber " + testNumber);
    }

  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Domino"))

        camera1.SetActive(false);
        camera2.SetActive(true);
    }

    void Update()
    {
        
    }
}
