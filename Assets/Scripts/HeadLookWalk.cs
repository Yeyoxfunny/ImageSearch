using UnityEngine;
using System.Collections;

public class HeadLookWalk : MonoBehaviour {

	public float velocity = 0.7f;
	public CharacterController controller;
	public bool isWalking = false;


	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Cardboard.SDK.Triggered) {
			isWalking = !isWalking;
		} else {
			controller.SimpleMove (Camera.main.transform.forward * velocity);
		}

		velocity = !isWalking ? 0.0f : 0.7f;
	}
}
