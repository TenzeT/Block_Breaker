using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    public Text txt;
    private int bricksDestroyed;
    // Use this for initialization
    void Start () {
        txt = GetComponent<Text>();
        bricksDestroyed = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateDestroyedBricks()
    {
        bricksDestroyed++;
        txt.text = "Destroyed: " + bricksDestroyed.ToString();
    }
}
