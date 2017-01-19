using UnityEngine;
using System.Collections;

public class end : MonoBehaviour {

	public AudioSource audioSource;
	//public GameObject plateforme;
	void OnTriggerEnter(Collider collider) 
	{


		if(collider.tag == "Player") 
		{	
			//plateforme.GetComponent<Animator>().SetBool("isThere",true);
			Debug.Log ("end");
			audioSource = GetComponent<AudioSource>();
			audioSource.Play();
			// il est midi
			GameObject.Find("sun").GetComponent<sun>().changeRotation (90f);
		}
	}
}
