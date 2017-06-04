using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogText : MonoBehaviour
{
    public Text text;

    private string fullText;

    private string currText = "";

    public int frames = 5;

    private int frameCounter = 0;

	// Use this for initialization
	void Start ()
	{
	    fullText = text.text;
	    text.text = "";
	}
	
	// Update is called once per frame
	void Update ()
	{

	    frameCounter++;
	    if (frameCounter >= frames)
	    {
	        frameCounter = 0;
	    }
	    else return;


	    if (fullText.Length == 0) return;

	    currText += fullText[0];
	    fullText = fullText.Substring(1);

	    text.text = currText;
    }
}
