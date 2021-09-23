using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float hInput;
    public float vInput;
    public float xRange = 11.38f;
    public float yRange = 4.97f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * speed * hInput * Time.deltaTime);
        transform.Translate(Vector3.up * speed * vInput * Time.deltaTime);
        //Create a wall on the -x side
        if(transform.position.x < -xRange) {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //Create a a wall on the x side
        if(transform.position.x > xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.y < -yRange) {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }
        if(transform.position.y > yRange) {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }
    }
}