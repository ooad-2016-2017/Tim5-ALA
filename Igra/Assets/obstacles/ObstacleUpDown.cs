using UnityEngine;
using System.Collections;

public class ObstacleUpDown : MonoBehaviour
{
    public float maxHeight = 5;
    public Grounding grounding;
    public float riseSpeed = 5;

    public bool isFalling = false;

	// Use this for initialization
	void Start () {
	
	}
	
	void FixedUpdate ()
	{
	    if (grounding.Grounded) isFalling = false;

	    if (isFalling) return;


	    Vector2 moveVec = transform.up * riseSpeed;

        GetComponent<Rigidbody2D>().position += moveVec;

        Debug.Log(riseSpeed);
	    if (transform.position.y >= maxHeight) isFalling = true;
	}
}
