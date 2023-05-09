using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovScript : MonoBehaviour
{
    public float movSpeed = 5;
    public float deadZone = -45;
    public BirdScript birdScript;

    // Start is called before the first frame update
    void Start()
    {
        birdScript = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!birdScript.isAlive()) {
            movSpeed = 0;
        }
        transform.position += (Vector3.left * movSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone) {
            Debug.Log("Pipe Destroyed");
            Destroy(gameObject);
        }
    }
}
