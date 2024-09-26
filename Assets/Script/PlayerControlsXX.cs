using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlsXX : MonoBehaviour
{
    float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * 5 * Time.deltaTime * horizontalInput);

        if(transform.position.x < -10)
        {
            transform.position = new Vector3 (-10, transform.position.y, transform.position.z);
        }
        
         if(transform.position.x > 10)
        {
            transform.position = new Vector3 (10, transform.position.y, transform.position.z);
        }
        

    }
}
