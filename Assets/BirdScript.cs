using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public float outBound = -18f;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myRigidbody.transform.position.y < outBound)
        {
           
            logic.gameOver();
            birdIsAlive = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
            {
                myRigidbody.velocity = Vector2.up * flapStrength;
            }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
   
}
