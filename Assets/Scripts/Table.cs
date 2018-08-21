using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour {
    public static Vector2 position;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        position.x = transform.position.x;
        position.y = transform.position.y;
		
	}
}
