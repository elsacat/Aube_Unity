using UnityEngine;
using System.Collections;

public class flower : MonoBehaviour {

	public AudioSource audioSource;
	public Rect labelPosition;
	string labelText;
	public GUIStyle labelStyle;
	private bool toggleGUI;
	public GameObject flowerReal;

	void OnTriggerEnter(Collider collider) 
	{


		if(collider.tag == "Player") 
		{	
			Debug.Log ("flower Trigger");

			flowerReal.GetComponent<Animator>().SetBool("isThere",true);
			// ne fait pas + 60 mais va à langle 60
			toggleGUI = true;


		}
	}

	void OnTriggerExit(Collider collider) {
		toggleGUI = false;
		flowerReal.GetComponent<Animator>().SetBool("isThere",false);
	}

	void OnGUI() {

		if(toggleGUI == true) {
			//GUI.Label (Rect (10, 300, 100, 20), "Bonjour"); 
			GUI.Label(labelPosition, "♫ Bonjour petit poète, je m'appelle Nina ♪", labelStyle);
			Debug.Log ("coucou");
		}
	}
}