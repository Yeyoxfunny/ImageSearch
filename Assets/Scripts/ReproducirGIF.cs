using UnityEngine;
using System.Collections;

public class ReproducirGIF : MonoBehaviour {

	int index;
	public int FramesPorSegundo=10;
	public Texture2D[] Frames;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		index=(int)(Time.time*FramesPorSegundo)%Frames.Length;
		GetComponent<Renderer> ().material.mainTexture = Frames [index];
	}
}
