using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootRacket : MonoBehaviour {
    private float vel;
    private float posY;

    // Use this for initialization
    void Start()
    {
        vel = 200 * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        posY = transform.position.y;
        print(Table.position.y);

        if (Boll.movement == 1 && posY < Table.position.y + 100) transform.Translate(0, vel, 0);
        if (Boll.movement == -1 && posY > Table.position.y - 100) transform.Translate(0, -vel, 0);
    }
}
