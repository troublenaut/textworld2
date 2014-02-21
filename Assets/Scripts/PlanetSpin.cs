using UnityEngine;
using System.Collections;

public class PlanetSpin : MonoBehaviour {

	public float rotX;
	public float rotY;
	public float rotZ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(rotX,rotY,rotZ);
	}
}
