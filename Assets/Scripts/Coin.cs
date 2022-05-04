using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float turnSpeed = 95f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }

    /// OnTriggerEnter is called when the other Collider enters the trigger.
    /// The other Collider involved in this collision.
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Obstacle>())
        {
            Destroy(gameObject);
            return;
        }

        if(other.gameObject.name != "Player"){
            return;
        }

        GameManager.inst.IncrementScore();

        Destroy(gameObject);
    }
}
