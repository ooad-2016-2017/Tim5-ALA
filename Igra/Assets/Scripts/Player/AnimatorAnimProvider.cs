using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorAnimProvider : IAnimationProvider
{
    public Animator animator;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
   

    public override void SetIdle(bool idle)
    {
        animator.SetBool("idle", idle);
    }

    public override void Jump()
    {
        animator.SetTrigger("jump");
    }

    public override void SetGrounded(bool grounded)
    {
        animator.SetBool("grounded", grounded);
    }

    public override void SetFalling(bool falling)
    {
        animator.SetBool("falling", falling);
    }
}
