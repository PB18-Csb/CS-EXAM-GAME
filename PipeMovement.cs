using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PipeMovement : MonoBehaviour
{
    public float pipeSpeed = 5;

    public float deadZone = -46;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * pipeSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
// this one was for pipe movement to the left 
// part of project remember 