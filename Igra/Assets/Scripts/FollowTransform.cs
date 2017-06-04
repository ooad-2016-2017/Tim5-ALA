using UnityEngine;
using System.Collections;

public class FollowTransform : MonoBehaviour {
    public Transform target;

    public Vector3 moveConstraints = Vector3.right;
    public Vector3 positionOffset;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 newPos = Vector3.zero;
        if (moveConstraints.x > 0.5f)
            newPos.x = target.position.x;
        if (moveConstraints.y > 0.5f)
            newPos.y = target.position.y;
        if (moveConstraints.z > 0.5f)
            newPos.z = target.position.z;

        if ( newPos.x > transform.position.x )
            transform.position = newPos + positionOffset;
	}
}
