using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public DeltaCamera DeltaCamera;
	public ARCAmera ARCamera;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		ARCamera.this_position = DeltaCamera.transform.position;
		ARCamera.this_rotation = DeltaCamera.transform.rotation;

	}
}
