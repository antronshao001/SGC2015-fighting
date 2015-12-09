using UnityEngine;
using System.Collections;
using Vuforia;

public class OutsiderPosition : MonoBehaviour {
	public Transform OusiderTransform;
	private Vector3 this_position;
	private Quaternion this_rotation;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (OusiderTransform.position);
		Debug.Log (OusiderTransform.rotation);
	}
}
