using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed = 150.0f;
    float hInput;
    float vInput;
    float xRange = 11.38f;
    float yRange = 4.97f;
    public GameObject projectile;
    public Transform launcher;

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.back, turnSpeed * hInput * Time.deltaTime);
        transform.Translate(Vector3.up * speed * vInput * Time.deltaTime);
        //Create a wall on the -x side
        if(transform.position.x < -xRange) {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //Create a wall on the x side
        if(transform.position.x > xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //Create a wall on the -y side
        if(transform.position.y < -yRange) {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }
        //Create a wall on the y side
        if(transform.position.y > yRange) {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(projectile, launcher.transform.position, projectile.transform.rotation);
        }
    }
}
