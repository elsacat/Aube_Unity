using UnityEngine;
using System.Collections;

public class BirdSound : MonoBehaviour {
	public AudioSource part5;
	public AudioSource birdSound;
	public AudioSource citySound;


	private AudioSource[] aSource;

	void Start () {
		aSource = GetComponents<AudioSource>();
		part5 = aSource [1];
		birdSound = aSource [0];
		citySound = aSource [2];
	}

		void OnTriggerEnter(Collider collider) 
		{
			if(collider.tag == "Player") 
			{	
				part5.Play();
				birdSound.PlayDelayed(10f);
			 	citySound.PlayDelayed (15f);
				//audioSourceWater.Play();
				// ne fait pas + 60 mais va à langle 60
				GameObject.Find("sun").GetComponent<sun>().changeRotation (15f);
			}
		}
}