using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public float lookSensitivity;           //How sensitive camera movement is to the mouse moving
    public float maxLookX;                  //How far player can look down
    public float minLookX;                  //How far player can look up
    private float rotX;                     //Current X rotation of camera
    private Camera camera;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //Get Components
        camera = camera.main;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move() 
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;

        rb.velocity = new Vector3(x, rb.velocity.y, z);
    }

    void CamLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity;
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity;
    }
}
