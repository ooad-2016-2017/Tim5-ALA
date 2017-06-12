using UnityEngine;
using System.Collections;

public class Grounding : IGrounding {
    public float distance = 0.25f;

    public override bool Grounded
    {
        get { return gndCnt > 0; }
    }

    private int gndCnt = 0;

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Terrain")
        {
            gndCnt++;
        }    
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Terrain")
        {
            gndCnt--;
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
