using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float velocityMultiplier;
    public LogicScript logic;
    public bool birdIsAlive;

    // Start is called before the first frame update
    void Start()
    {
        birdIsAlive = true;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) {
            myRigidbody.velocity += Vector2.up * velocityMultiplier;
        }
        
    }

    public bool isAlive() {
        return birdIsAlive;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        birdIsAlive = false;
        logic.gameOver();
    }
}
