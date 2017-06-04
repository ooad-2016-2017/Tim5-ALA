using UnityEngine;
using System.Collections.Generic;

public class EndGameScene : MonoBehaviour {
    public List<GameObject> ToEnable;
    public List<GameObject> ToDisable;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void OnTriggerEnter2D(Collider2D col)
    {
        if ( col.transform.tag == "Player" )
        {
            var player = col.transform.GetComponent<Player>();

            player.GoIdle();


            foreach (var obj in ToEnable) obj.SetActive(true);
            foreach (var obj in ToDisable) obj.SetActive(false);
        }
    }
}
