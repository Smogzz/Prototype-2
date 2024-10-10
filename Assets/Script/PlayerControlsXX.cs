using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlsXX : MonoBehaviour
{
    float horizontalInput;
    public float xRange = 23;
    public float speed = 15;
    public GameObject progectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the players horizontal input//
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        //Keep the player at xrange left//
        if(transform.position.x < - xRange)
        {
            transform.position = new Vector3 (-xRange, transform.position.y, transform.position.z);
        }
        
         if(transform.position.x > xRange)
        {
            transform.position = new Vector3 (xRange, transform.position.y, transform.position.z);
        }
        
        //check the player is pressing space//
        if(Input.GetKeyDown(KeyCode.Space))
        { 
        //launch projectile from the player//
            Instantiate(progectilePrefab, transform.position, progectilePrefab.transform.rotation);
        }
    }
}
