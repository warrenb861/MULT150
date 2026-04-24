using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;
    public int numLeft = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            numLeft -= 1;
            Destroy(collidedWith);
            if (numLeft <= 0)
            {
                isSolved = true;
                GetComponent<Light>().enabled = false;
            }
        }
    }
}
