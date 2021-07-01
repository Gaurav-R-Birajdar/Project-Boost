using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] float mainThrust = 1000f;
    [SerializeField] float rotateThrust = 1000f;
    Rigidbody myRigidbody;
    void Start()
    {
       myRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ProcessThrust();
        ProcessRotate();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            myRigidbody.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        }

   }

   void ProcessRotate()
   {
       if (Input.GetKey(KeyCode.A))
       {
           myRigidbody.freezeRotation = true;
           transform.Rotate(Vector3.forward * rotateThrust * Time.deltaTime);
           myRigidbody.freezeRotation = false;
       }

       else if (Input.GetKey(KeyCode.D))
       {
           myRigidbody.freezeRotation = true;
           transform.Rotate(Vector3.back * rotateThrust * Time.deltaTime);
           myRigidbody.freezeRotation = false;
       }
   }
}
