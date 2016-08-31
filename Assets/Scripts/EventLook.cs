using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EventLook : MonoBehaviour {

	public float timerDuration = 2f;

	public float lookTimer = 0f;

	public bool isLookedAd = false;

	private GameObject[] imagenPrincipal;
	private GameObject[] imagenSecundaria;

	void Awake(){
		imagenPrincipal = GameObject.FindGameObjectsWithTag ("Principal");
		imagenSecundaria = GameObject.FindGameObjectsWithTag ("Secundario");
		cambiarImagenes (imagenSecundaria, false);
	}

	void Update () {
		if (isLookedAd) {
			lookTimer += Time.deltaTime;
			if (lookTimer > timerDuration) {
				lookTimer = 0f;
				cambiarImagenes (imagenPrincipal, false);
				cambiarImagenes (imagenSecundaria, true);
				//gameObject.SetActive (false);
			} 
		}else {
			lookTimer = 0f;
		}
	}

	public void SetGazedAt(bool gazedAt){
		isLookedAd = gazedAt;
	}

	void cambiarImagenes(GameObject[] imagenes, bool estado){
		foreach (GameObject objeto in imagenes) {
			objeto.SetActive (estado);
		}
	}
}
