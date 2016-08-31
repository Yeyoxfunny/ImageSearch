using UnityEngine;
using System.Collections;

public class AgrandarImagen : MonoBehaviour {

	public bool isLookedAd = false;

	// Update is called once per frame
	void Update () {
		if (isLookedAd) {
			transform.localScale = new Vector3(2,2,2); 
		}else {
			transform.localScale = new Vector3 (1, 1, 1);
		}
	}

	public void SetGazedAt(bool gazedAt){
		isLookedAd = gazedAt;
	}
}
