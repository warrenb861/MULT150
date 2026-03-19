using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 22; x<=100; x+=2)
        {
            Debug.Log(x);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
