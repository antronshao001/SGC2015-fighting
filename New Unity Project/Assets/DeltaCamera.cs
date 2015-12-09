using UnityEngine;
using System.Collections;

public class DeltaCamera : MonoBehaviour {

	public Vector3 this_position;
	public Quaternion this_rotation;

	// Use this for initialization
	void Start () {
		this_position = gameObject.transform.localPosition;
		this_rotation = gameObject.transform.localRotation;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
