using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 velocity = new Vector3 (1f, 0f, 0f);
		GetComponent<Rigidbody>().AddForce (velocity * speed);
	}
}
