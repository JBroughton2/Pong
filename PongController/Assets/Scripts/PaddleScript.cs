using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public GameObject ball;
    public Vector2 forceAdded;
    public float speedFloatX;
    public float speedFloatY;
    public GameManager gm;
    public GameObject manager;
    void Start()
    {
        forceAdded = new Vector2(speedFloatX, speedFloatY);
        gm = manager.GetComponent<GameManager>();
    }

    void Update()
    {
        if(gm.ballDestroyed)
        {
            forceAdded = new Vector2(0, 0);
            speedFloatX = 0;
            speedFloatY = 0;
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(ball)
        other.attachedRigidbody.AddForce(forceAdded);
        speedFloatX += 25;
        speedFloatY += 25;
        forceAdded = new Vector2(speedFloatX, speedFloatY);
    }
}
