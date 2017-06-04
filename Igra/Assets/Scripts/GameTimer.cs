using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public Text text;

    private string prefix;

    public int startMinutes = 3;
    public int startSeconds = 0;

    private DateTime timeLeft;

    private float timer = 0;
    public int distance = 1000;

    public Player player;

    public Transform kolega;

	// Use this for initialization
	void Start ()
	{
	    prefix = text.text;

	    timeLeft = new DateTime(2017, 4, 6, 12, startMinutes, startSeconds);

	    kolega.position = player.transform.position + Vector3.right * distance;
	}

    private float lateTimer = 0;
	// Update is called once per frame
	void Update ()
	{

	    string t = String.Format("{0:00}:{1:00}", timeLeft.Minute, timeLeft.Second);

	    if (!(timeLeft.Minute == 0 && timeLeft.Second <= 0))
	    {
	        timer += Time.deltaTime;
	        if (timer >= 1)
	        {
	            timer -= 1;

	            timeLeft = timeLeft.AddSeconds(-1);

	        }
	    }
	    else
	    {
	        lateTimer += Time.deltaTime;
            
            t += String.Format("( kasnite {0:00}s )",(int)((lateTimer)));
	    }
        

        text.text = String.Format(prefix, t, distance - player.transform.position.x );
	}
}
