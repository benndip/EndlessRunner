using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float horizontalMultiplier = 2f;
    // GetComponent<Rigidbody> playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        if(Input.GetKey("left")){
            transform.position += Vector3.left * speed * Time.deltaTime * horizontalMultiplier;
        }
        if(Input.GetKey("right")){
            transform.position += Vector3.right * speed * Time.deltaTime * horizontalMultiplier;
        }
    }

}
