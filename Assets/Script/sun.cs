using UnityEngine;
using System.Collections;

public class sun : MonoBehaviour {
	private float rotationX;
	public float speed = 1f;
	// Use this for initialization
	void Start () {
		rotationX = transform.rotation.eulerAngles.x;
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.Euler (rotationX, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z), speed * Time.deltaTime);
	}

	public void changeRotation (float angle)
	{
		rotationX = angle;
	}
}
