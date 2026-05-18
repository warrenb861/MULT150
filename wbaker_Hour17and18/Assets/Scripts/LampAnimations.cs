using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampAnimations : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) {
            anim.SetInteger("AnimationKey",1);
        } else if (Input.GetKeyDown(KeyCode.A)) {
            anim.SetInteger("AnimationKey",2);
        } else if (Input.GetKeyDown(KeyCode.S)) {
            anim.SetInteger("AnimationKey",3);
        } else if (Input.GetKeyDown(KeyCode.D)) {
            anim.SetInteger("AnimationKey",4);
        } 
    }
}
