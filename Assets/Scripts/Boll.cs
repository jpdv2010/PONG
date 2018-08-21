using UnityEngine;

public class Boll : MonoBehaviour {
    private float vel;
    private Vector2 direction;
    private int initialDirection;
    public static int movement;
    public static Vector2 position;

	// Use this for initialization
	void Start () {
        vel = 300 * Time.deltaTime;
        initialDirection = Util.getRandom(0,360);
        transform.Rotate(0 , 0, initialDirection);
	}
	
	// Update is called once per frame
	void Update () {
        /*print("Table position X: " + Table.position.x);
        print("Table position Y: " + Table.position.y);
        print("Bool position X: " + position.x);
        print("Bool position Y: " + position.y);
        if ((position.y > (Table.position.y - 100))
            && (position.y < (Table.position.y + 100))
            && (position.x > (Table.position.x - 100))
            && (position.x < (Table.position.x + 100)))
        {
        }*/
        transform.Translate(vel, 0, 0);
        movement = direction.y > 0 ? 1 : direction.y < 0 ? -1 : 0; 	
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("racket")) ;
    }
}
