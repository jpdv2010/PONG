using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    public static int playerScore;
    public static int bootScore;
    public GUIText score;

	// Use this for initialization
	void Start () {
        playerScore = 0;
        bootScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
        print("Player: " + playerScore);
        print("Boot: " + bootScore);
        score.text = "Player " + playerScore + " : " + bootScore + " Boot";
	}
}
