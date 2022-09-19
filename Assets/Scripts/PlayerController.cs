using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float speed = 20;
    private float turnSpeed = 45;
    private float horizontalInput;
    private float forwardInput;
    // Update is called once per frame

    void Update()
    {
        //Move the vehicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //vertical movement//
        transform.Translate(Vector3.forward *Time.deltaTime* speed * forwardInput);
        //rotates horizantal//
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);


    }
}
