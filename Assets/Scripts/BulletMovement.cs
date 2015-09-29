using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

	public float bSpeed = 10;
	public float maxLifeTime;
	private float _lifeTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * bSpeed * Time.deltaTime);
		//transform.Translate.position = new Vector3(xSpeed,Yspeed,Zspeed);
		_lifeTime -= Time.deltaTime;
	}
}