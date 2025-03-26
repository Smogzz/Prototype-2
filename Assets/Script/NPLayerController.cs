using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPLayerController : MonoBehaviour
{
    float xInput;
    float yInput;
    public float xRange = 23;
    public float moveSpeed = 20;
     public GameObject progectilePrefab;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizantal");
        yInput = Input.GetAxis("Vertical");
         //check the player is pressing space//
        if(Input.GetKeyDown(KeyCode.Space))
        { 
        //launch projectile from the player//
            Instantiate(progectilePrefab, transform.position, progectilePrefab.transform.rotation);
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(xInput * moveSpeed, 0 , yInput * moveSpeed);
    }


}
