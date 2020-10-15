using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Vector2 speed = new Vector2(1,1);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(speed.x/100, speed.y/100, 0);
    }

    void OnCollisionEnter(Collision collision){
        Debug.Log(collision.gameObject);
        if(collision.gameObject.name == "Paddle"){
            speed.y *= -1;
        }
    }
}
