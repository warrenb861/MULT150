using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x <= 10; x++) {
            Instantiate(prefab,new Vector3(-1+(x*3),0,-5),transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B)) {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
