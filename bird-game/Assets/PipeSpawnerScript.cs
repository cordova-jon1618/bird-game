using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float heightOffset = 5;
    private float timer = 0;
    public float spawnRate = 5;

    // Start is called before the first frame update
    void Start()
    {
        spawner();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawner();
            timer = 0;
        }
    }

    void spawner()
    {
        float highestOffset = transform.position.y + heightOffset;
        float lowestOffset = transform.position.y - heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(highestOffset, lowestOffset), 0), transform.rotation);
    }
}//end class
