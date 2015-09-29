using UnityEngine;
using System.Collections;

public class MoveWorld : MonoBehaviour {
	//t means tilt
	private bool W, A, S, D;
	private float tLeft, tForward;
	private int tSpeed = 2;
	
	[SerializeField]
	private int maxAngle = 5;
	
	void Update()
	{
		inputs();
		tiltPlatform();
	}
	
	//tilting the platform
	void tiltPlatform()
	{
		//adding angle
		if (W) { tForward += tSpeed; }
		else if (S) { tForward -= tSpeed; }
		if (A) { tLeft += tSpeed; }
		else if (D) { tLeft -= tSpeed; }
		
		//makes the movement smooth
		if (tForward > 0) tForward -= tForward / maxAngle;
		else if (tForward < 0) tForward -= tForward / maxAngle;
		if (tLeft > 0) tLeft -= tLeft / maxAngle;
		else if (tLeft < 0) tLeft -= tLeft / maxAngle;
		
		//actually changes the angle
		this.transform.eulerAngles = new Vector3(tForward, 0, tLeft);
	}
	
	//getting the inputs
	void inputs()
	{
		if (Input.GetKeyDown(KeyCode.W)) { W = true; }
		else if (Input.GetKeyDown(KeyCode.S)) { S = true; }
		if (Input.GetKeyDown(KeyCode.A)) { A = true; }
		else if (Input.GetKeyDown(KeyCode.D)) { D = true; }
		
		if (Input.GetKeyUp(KeyCode.W)) { W = false; }
		else if (Input.GetKeyUp(KeyCode.S)) { S = false; }
		if (Input.GetKeyUp(KeyCode.A)) { A = false; }
		if (Input.GetKeyUp(KeyCode.D)) { D = false; }
	}
}
