using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonAnimationSimplePeople : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;
    private float maxSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        print("SPEED= "+rb.velocity.magnitude / maxSpeed+" velosoty = "+ rb.velocity.magnitude+" maxspeed= "+ maxSpeed);
        animator.SetFloat("Speed_f", rb.velocity.magnitude / maxSpeed);
    }
}
