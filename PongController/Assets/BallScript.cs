using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public int initialRot;
    public Vector2 startingSpeed;
    public bool destroyed;
    public GameManager gm;
    public GameObject gameMaster;
    public Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gm = gameMaster.GetComponent<GameManager>();
        moveBall();
    }

    void Update()
    {

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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Win"))
        {
            destroyed = true;
            Destroy(this.gameObject);
        }
    }

    void ChooseStart()
    {
        initialRot = Random.Range(0,360);
    }
}
