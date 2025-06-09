using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{

    public MannagerScript manage;

    // Start is called before the first frame update
    void Start()
    {
        manage = GameObject.FindGameObjectWithTag("Mannager").GetComponent<MannagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if(Collision.gameObject.layer == 3)
        {
            manage.AddScore(1);
        }
    }
}
