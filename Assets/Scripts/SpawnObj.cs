using UnityEngine;
using System.Collections;

public class SpawnObj : MonoBehaviour
{
	[SerializeField]
	private float spawnTime = 5f;//time between spawns
	[SerializeField]
	private float spawnDelay = 3f; //time for spawntime to start
	[SerializeField]
	private GameObject[] obstacle;
	private GameObject world;

	void Start ()
	{
		// Call spawn repeatitly when timer is over
		InvokeRepeating("Spawn", spawnDelay, spawnTime);
		world = GameObject.Find ("World");
	}
	
	
	void Spawn ()
	{
		int obstacleIndex = Random.Range(0, obstacle.Length);
		Debug.Log (obstacleIndex);
		world = Instantiate (obstacle[obstacleIndex], this.transform.position, this.transform.rotation) as GameObject;
		world.transform.parent = transform;
	}
}