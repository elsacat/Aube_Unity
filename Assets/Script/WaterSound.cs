using UnityEngine;
using System.Collections;

public class WaterSound : MonoBehaviour 
{
	
	public AudioSource audioSourceWater;
	public AudioSource audioSourcePart4;
	private AudioSource[] aSource;
	//public GameObject deesse;

	void Start () {
		aSource = GetComponents<AudioSource>();
		audioSourceWater = aSource [0];
		audioSourcePart4 = aSource [1];
	}

	void OnTriggerEnter(Collider collider) 
	{

		if(collider.tag == "Player") 
		{
			audioSourcePart4.Play();
			//deesse.SetActive (true);
			audioSourceWater.PlayDelayed(4f);
			//audioSourceWater.Play();

			GameObject.Find("sun").GetComponent<sun>().changeRotation (-5f);
		}
	}
}