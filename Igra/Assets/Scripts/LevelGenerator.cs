using UnityEngine;
using System.Collections;

public class LevelGenerator : MonoBehaviour {
    public float deltaPosition = 400;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("OnTriggerExit2D");
        if (col.tag != "Terrain") return;

        col.transform.position += Vector3.right * deltaPosition;
    }
}
