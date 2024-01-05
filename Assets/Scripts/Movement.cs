using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rbody;
    [SerializeField] float mainThrust = 1200f;
    [SerializeField] float rotateSpeed = 1f;


    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }


    void ProcessThrust() {
        if (Input.GetKey(KeyCode.Space)){
            //A Vector is both direction and magnitude
            //* Time.deltaTime makes it frame rate independent 
            rbody.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        }
    }

    void ProcessRotation(){
        if (Input.GetKey(KeyCode.A)){
            transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D)){
            transform.Rotate(Vector3.back * rotateSpeed * Time.deltaTime);
        }
    }
}
