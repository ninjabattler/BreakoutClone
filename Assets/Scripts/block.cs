using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    public float speed = 2;
    void OnCollisionEnter(Collision collision){
        GameObject ball = GameObject.Find(collision.gameObject.name);
        Vector2 ballSpeed = ball.GetComponent<ball>().speed;

        float speedX = speed;
        float speedY = speed;

        if(ballSpeed.x < 0){
            speedX *= -1;
        }
        if(ballSpeed.y < 0){
            speedY *= -1;
        }

        ball.GetComponent<ball>().speed = new Vector2(speedX, speedY);
        Destroy(gameObject);
    }
}
