using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public List<GameObject> GameStartToEnable;

    public List<GameObject> GameStartToDisable;


    public void StartGame()
    {
        foreach ( var go in GameStartToEnable ) go.SetActive(true);
        foreach ( var go in GameStartToDisable ) go.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();    
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
