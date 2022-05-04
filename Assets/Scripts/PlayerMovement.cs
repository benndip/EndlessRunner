using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public bool alive = true;
    public float speed = 10f;
    public float horizontalMultiplier = 1.3f;
    public float speedIncreasePerPoint = 0.05f;
    public Rigidbody rb;
    public float jumpForce = 300f;
    public bool canJump = true;
    Animator animator;

    // GetComponent<Rigidbody> playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
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

        // ::=> First method to make component move

        transform.position += transform.forward * speed * Time.fixedDeltaTime;

        if(Input.GetKey("left")){
            transform.position += Vector3.left * speed * Time.fixedDeltaTime * horizontalMultiplier;
        }
        if(Input.GetKey("right")){
            transform.position += Vector3.right * speed * Time.fixedDeltaTime * horizontalMultiplier;
        }

        RaycastHit hit;
        if(Physics.Raycast(transform.position, Vector3.down, out hit, 0.5f))
        {
            canJump = true;
            animator.SetBool("isJumping", false);
        }
        
        if (canJump && Input.GetKeyDown("space"))
        {
            canJump = false;
            GetComponent<Rigidbody>().AddForce(0, jumpForce, 0);
            animator.SetBool("isJumping", true);
        }


        // ::=> Second method to make a component move

       /* Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove + transform.position);*/

    }

    public void Die(){
        alive = false;
        Invoke("Restart", 2);

    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
