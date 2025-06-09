using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerscript : MonoBehaviour
{

    public GameObject pipe;
    public float spawnrate = 2;
    public float timer = 0;
    public float highestOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawner();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }

        else
        {
            spawner();
        }
    }

    void spawner()
    {
        float lowestpoint = transform.position.y - highestOffset;
        float highestpoint = transform.position.y + highestOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
        timer = 0;
    }
}
