using UnityEngine;
using System.Collections;

public class testeVideo : MonoBehaviour {
	void Start () {
		Invoke("doPlay",1.0f);
	}
	
	void doPlay()
	{
		Debug.Log("Starting Movie: " + "colgate.mp4");  
		Handheld.PlayFullScreenMovie ("colgate.mp4", Color.black, FullScreenMovieControlMode.Full);
		Debug.Log("All Done!"); 
	}
}
