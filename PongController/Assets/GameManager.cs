using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public Vector3 startPosition;
    public bool destroyed;
    public BallScript bs;

    void Start()
    {
        bs = ball.GetComponent<BallScript>();
        
    }

    void Update()
    {
        spawnBall();
    }

    void spawnBall()
    {
        if (bs.destroyed)
        {
            Instantiate(ball, startPosition, Quaternion.identity);
            bs.rb = ball.GetComponent<Rigidbody2D>();
            bs.moveBall();
            bs.destroyed = false;
        }
    }

}
