using UnityEngine;
using System.Collections;

public class wind : MonoBehaviour {
	public AudioSource audioSource;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider) 
	{


		if(collider.tag == "Player") 
		{
			Debug.Log ("Wind Trigger");
			// Debug.Log ("Turbulence " + GameObject.Find ("WindZone").GetComponent<WindZone> ().windTurbulence);
			// Debug.Log ("Turbulence " + GameObject.Find ("WindZone").GetComponent<WindZone> ().windMain);
			// 
			GameObject.Find ("WindZone").GetComponent<WindZone> ().windMain = 5f;
			GameObject.Find ("WindZone").GetComponent<WindZone> ().windTurbulence = 5f;

			audioSource = GetComponent<AudioSource>();
			audioSource.Play();

			GameObject.Find("sun").GetComponent<sun>().changeRotation (-7f);
		}
	}
}
