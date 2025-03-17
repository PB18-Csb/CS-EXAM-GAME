using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class THEBIRD : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    // i wrote this basically so that the script can talk to the rigid body,
    // made it public so that we can access it outside the script and named it my rigidbody
    
    public float force;
    
    // used a point float variable for the force by which the bird actuallyt goes up 
    // i did this so i couly directly change the force on unity and wouldnt have to cahnge it in the script like a noob
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
            // used the if statement here because the linearvelocity code as it is in update ran continously 
        // so i made a condition that if unity gets the input someone pressed the space bar omly then bird flys
        {
            myRigidbody.linearVelocity = Vector2.up * force;
        }
        // the number assigned to the velocity is basically a vector and vector 2 up is 0,1 
        // and the reason i multiplied it by 10 was to increase the intensity of it 
    }
}
