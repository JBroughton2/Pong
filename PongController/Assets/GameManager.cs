using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public Vector3 startPosition;
    public BallScript bs;
    private bool ballDestroyed = false;

    void Start()
    {
        bs = ball.GetComponent<BallScript>();
        startPosition = ball.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        ballDestroyed = true;
        spawnBall();
    }


    void spawnBall()
    {
        if (ballDestroyed == true)
        {
            Instantiate(ball, startPosition,Quaternion.identity);
            bs.moveBall();
        }
    }

}
