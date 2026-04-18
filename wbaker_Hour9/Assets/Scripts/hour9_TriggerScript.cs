using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hour9_TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        print("OnTriggerEnter -> " + gameObject.name);
    }

    void OnTriggerStay(Collider other)
    {
        print("OnTriggerStay -> " + gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        print("OnTriggerExit -> " + gameObject.name);
    }
}
