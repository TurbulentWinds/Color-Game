using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour () {

    public float speed;
    private Rigidbody2D rb2d;

    void Start () {
        rb2d = GetComponent<RigidBody2D>();
    }

    void FixedUpdate () {
    
        float moveHorizontal = Input.GetAxis ("Horizontal");
	float moveVertical = Input.GetAxis ("Vertical");

	Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

	rb2d.AddForce (movement * speed);
    }
	
    void ChangeColor (Color color) {
        GameObject[] go = (GameObject) GameObject.FindObjectsOfType(GameObject);
	foreach(GameObject gameObject in go) {
	     if (gameObject.GetComponentOfType<GameColor>().color == color) {
	     	gameObject.enabled = false;
	     } else {
	        gameObject.enable = true;
	     }
	}
    } 
}
