using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float moveSpeed = 10;

    public float jumpIntensity = 100;

    public Grounding grounding;

	// Use this for initialization
	void Start () {
	
	}
	
    void Jump()
    {

    }

	// Update is called once per frame
	void Update () {

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
                Jump();        
            }
        }
        #endregion
    }
}
