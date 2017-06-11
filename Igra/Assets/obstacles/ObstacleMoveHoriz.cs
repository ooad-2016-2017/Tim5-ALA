using UnityEngine;
using System.Collections;

public class ObstacleMoveHoriz : MonoBehaviour
{
    public Vector2 moveVector;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
	    GetComponent<Rigidbody2D>().position += moveVector * Time.deltaTime;
	}
}
