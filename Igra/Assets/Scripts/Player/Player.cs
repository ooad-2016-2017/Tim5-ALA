using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float moveSpeed = 10;

    public float jumpIntensity = 100;
    public float dieIntensity = 100;

    public IGrounding grounding;
    

    private bool isFalling = false;
    public int fallFrameCount = 3;

    private int fallFrameCounter = 0;

    private Vector3 lastSamplePos = Vector3.zero;

    private bool isIdle = false;

    public IAnimationProvider animProvider;

    public void GoIdle()
    {
        this.isIdle = true;
    }

    private void updateFalling()
    {
        fallFrameCounter++;
        if (fallFrameCounter < fallFrameCount) return;

        fallFrameCounter = 0;

        if (lastSamplePos.sqrMagnitude < 0.01f)
        {
            lastSamplePos = transform.position;
        }

        isFalling = lastSamplePos.y - transform.position.y > 0.001f;
    }

    public void Die()
    {
        float upIntensity = transform.GetComponent<Rigidbody2D>().velocity.y;
        if (upIntensity < jumpIntensity / 1000) upIntensity = jumpIntensity;

        transform.GetComponent<Rigidbody2D>().AddForce((-transform.right) * dieIntensity + transform.up * upIntensity);
    }

    // Use this for initialization
    void Start () {
	
	}
	
    void Jump()
    {
        if ( grounding.Grounded && transform.GetComponent<Rigidbody2D>().velocity.y < 1f )
            transform.GetComponent<Rigidbody2D>().AddForce(transform.up * jumpIntensity);
    }



	// Update is called once per frame
	void Update ()
	{
	    if (isIdle)
	    {
	        animProvider.SetIdle(isIdle);

            return;
	    }

        #region Move
        { 
            Vector3 moveVector = Vector3.zero;

            moveVector += Vector3.right * moveSpeed * Time.deltaTime;

            transform.position += moveVector;
        }
        #endregion

        #region Jump
        {
            if ( Input.GetKeyDown(KeyCode.Space) )
            {
                animProvider.Jump();
                Jump();
            }
            
        }
        #endregion

        updateFalling();

        animProvider.SetGrounded(grounding.Grounded);
        animProvider.SetFalling(isFalling);
    }
}
