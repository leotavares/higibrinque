using UnityEngine;
using System.Collections;

public class escovaLimpar : MonoBehaviour {
	public int teste=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collision) {
		collision.gameObject.GetComponent<corMudar>().corT+=1;
	}
}
