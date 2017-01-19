using UnityEngine;
using System.Collections;

public class deesse : MonoBehaviour {
	public GameObject mydeesse;

	void OnTriggerEnter(Collider collider) 
	{
		if(collider.tag == "Player") 
		{	
			mydeesse.SetActive (true);
		}
	}
}
