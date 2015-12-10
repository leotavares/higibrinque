using UnityEngine;
using System.Collections;

public class createCoin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find ("hud").GetComponent<nomeCarregar> ().totalPoints++;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void triggerCoin(){

	}
}
