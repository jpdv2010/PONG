using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGoal : MonoBehaviour {

    private float posX;
    private Vector3 bollInstancePosition;
    // Use this for initialization
    void Start()
    {
        bollInstancePosition.x = 0;
        bollInstancePosition.y = 0;
    }

    // Update is called once per frame
    void Update()
    {
        posX = transform.position.x;
        if (Boll.position.x < posX)
        {
            Boll.position.x = 0;
            Boll.position.y = 0;
            Score.bootScore++;
        }
    }
}
