using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public int initialRot;
    private Quaternion rotation;
    public Vector2 startingSpeed;
    public Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveBall();
        Random.seed = (int)System.DateTime.Now.Ticks;
    }

    public void moveBall()
    {
        ChooseStart();
        if (initialRot == 180 || initialRot == 0)
        {
            ChooseStart();
        }
        else
        {
            rb.AddForce(startingSpeed);
        }
    }

    void ChooseStart()
    {
        initialRot = Random.Range(0,180);
        this.gameObject.transform.rotation = new Quaternion(0, 0, initialRot, 0);
    }
}
