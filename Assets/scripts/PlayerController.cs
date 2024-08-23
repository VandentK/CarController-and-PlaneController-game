using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //propeties of the class
    private float speed = 20.0f;
    private float turnSpeed = 10.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    //from monobehaviour class
    void Start()
    {
        
    }

    // Update is called once per frame
    //from monobehaviour class
    void Update()
    {
        //for the input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //we'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //rotate the y axis of the bus
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
