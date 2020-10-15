using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    public float speed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move Left
        if(Input.GetKey("a")){
            gameObject.transform.Translate(Vector3.left * speed / 100);
        }
        //Move Right
        if(Input.GetKey("d")){
            gameObject.transform.Translate(Vector3.right * speed / 100);
        }
    }
}
