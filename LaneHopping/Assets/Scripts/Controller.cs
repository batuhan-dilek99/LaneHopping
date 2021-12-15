using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Rigidbody rigidbody;
    public bool isGrounded;
    public float thrust;
    Vector3 moveRight;
    Vector3 moveLeft;
    public float playerSpeed;

    public int maxSpeed;

    [SerializeField] Player player;
   // public Animator animator;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
       // animator = GetComponent<Animator>();
        moveRight = new Vector3(2, 0, 0);
        moveRight = moveRight.normalized * playerSpeed; //* Time.deltaTime;
        moveLeft = new Vector3(-2, 0, 0);
        moveLeft = moveLeft.normalized * playerSpeed;// * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other) {
        isGrounded = true;
        if(other.gameObject.tag == "Obstacle"){
            player.crashed = true;
            Time.timeScale = 0;
        }
        
    }
    private void OnCollisionExit(Collision other) {
        isGrounded = false;     
    }
    void Update()
    {   
        
        //animator.SetTrigger("Run");
        if (Input.GetKeyDown("space") && isGrounded){
            rigidbody.AddForce(transform.up * thrust, ForceMode.Impulse);
        }
        if(Input.GetKey("d")){
            if(rigidbody.velocity.magnitude > maxSpeed){
                rigidbody.AddForce(new Vector3(0,0,0));
            }
            else{
                rigidbody.AddForce(moveRight);
            }
        }
        if (Input.GetKey("a")){
            if(Mathf.Abs(rigidbody.velocity.magnitude) > maxSpeed){
                rigidbody.AddForce(new Vector3(0,0,0));
            }
            else{
                rigidbody.AddForce(moveLeft);
            }
        }
    }
}
