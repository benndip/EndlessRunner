using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public bool alive = true;
    public float speed = 10f;
    public float horizontalMultiplier = 1.3f;
    // GetComponent<Rigidbody> playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < 0){
            Die();
        }
    }

    public void FixedUpdate(){
        if(!alive) return;
        transform.position += transform.forward * speed * Time.fixedDeltaTime;

        if(Input.GetKey("left")){
            transform.position += Vector3.left * speed * Time.fixedDeltaTime * horizontalMultiplier;
        }
        if(Input.GetKey("right")){
            transform.position += Vector3.right * speed * Time.fixedDeltaTime * horizontalMultiplier;
        }

    }

    public void Die(){
        alive = false;
        Invoke("Restart", 2);

    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
