using UnityEngine;
using System.Collections;

public class GameCamera : MonoBehaviour {

    public Player player;

    public float moveSpeed = 100;

    public Vector3 positionOffset;

    public float positionZ = -500;
    public float positionY = 0;

    // Use this for initialization
    void Start () {
        transform.position = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (player == null) return;

        {
            Vector3 targetPos = new Vector3(player.transform.position.x, positionY, positionZ) + positionOffset;


            Vector3 newPos = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * moveSpeed);

            transform.position = newPos;
        }
	}
}
