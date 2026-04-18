using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mX = 0.0f;
        float mY = 0.0f;
        float movementSpeed = 0.005f;
        if(Input.GetKey(KeyCode.UpArrow))
        {
            mY += movementSpeed;
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            mY -= movementSpeed;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            mX -= movementSpeed;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            mX += movementSpeed;
        }
        transform.Translate(mX, mY, 0);
    }
}
