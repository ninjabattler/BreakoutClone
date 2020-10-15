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
        if(collision.gameObject.name == "Paddle" || collision.gameObject.name == "Ceiling"){
            speed.y *= -1;
        }
        if(collision.gameObject.name == "Wall"){
            speed.x *= -1;
        }
    }
}
