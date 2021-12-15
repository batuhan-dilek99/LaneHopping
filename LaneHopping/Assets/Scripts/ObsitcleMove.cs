using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsitcleMove : MonoBehaviour
{
    [SerializeField] public GameObject obsticle;

    public float force;

    Rigidbody rb;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other) {
        
    }
    private void OnCollisionExit(Collision other) {
        Destroy(obsticle);
    }
    private void Update() {
        if(Mathf.Abs(rb.velocity.magnitude) > 6){
            rb.AddForce(new Vector3(0,0,0));
        }
        else{
            rb.AddForce(new Vector3(0, 0, -6));
        }
        
    }
}
