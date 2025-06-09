using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{

    private Rigidbody2D rb;
    public float flapstrenght = 5;
    public MannagerScript manage;
    public bool BirdIsAlive = true;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    
        manage = GameObject.FindGameObjectWithTag("Mannager").GetComponent<MannagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && BirdIsAlive)
        {
            rb.linearVelocity = new Vector2(0, flapstrenght);
        }

        if (transform.position.y > 5 || transform.position.y < -5)
        {
            manage.gameOver();
            BirdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        manage.gameOver();
        BirdIsAlive = false;
    }
}
