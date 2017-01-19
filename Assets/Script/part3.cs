using UnityEngine;
using System.Collections;

public class part3 : MonoBehaviour {
	public AudioSource audioSource;
	void OnTriggerEnter(Collider collider) 
	{


		if(collider.tag == "Player") 
		{	
			Debug.Log ("flower Trigger");
			audioSource = GetComponent<AudioSource>();
			audioSource.Play();
			// ne fait pas + 60 mais va à langle 60
			GameObject.Find("sun").GetComponent<sun>().changeRotation (-3f);



		}
	}
}
