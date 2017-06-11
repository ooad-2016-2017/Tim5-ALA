using UnityEngine;
using System.Collections;

public class ObstacleSpawner : MonoBehaviour
{
    public float SpawnDistance = 5;
    private float lastSpawn = 0;

    public float chance = 40;
    

    public Transform[] Obstacles;

    public Transform player;

    public Vector3 spawnPosition;

    public GameTimer gameTimer;

	// Use this for initialization
	void Start () {
	
	}

    void Spawn()
    {
        int n = Random.Range(0, 100);

        if (n > chance) return;

        Instantiate(
            Obstacles[Random.Range(0, Obstacles.Length)],
            new Vector3(player.position.x + spawnPosition.x, spawnPosition.y, spawnPosition.z),
            Quaternion.identity
        );

    }

	// Update is called once per frame
	void Update ()
	{
	    if (gameTimer.DistanceLeft < SpawnDistance * 2) return;

	    if (player.position.x - lastSpawn > SpawnDistance)
	    {
	        lastSpawn = player.position.x;
	        Spawn();
	    }
	}
}
