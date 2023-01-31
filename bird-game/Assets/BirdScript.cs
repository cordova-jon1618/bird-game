using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public float flapStrength = 5;
    public Rigidbody2D myRigidbody;
    public bool birdIsAlive = true;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) == true && birdIsAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        if (Input.GetKey(KeyCode.Escape) == true)
        {
            Application.Quit();
        }
    }//end Update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}//end class
