using UnityEngine;
using System.Collections;

public class ataqueToothFinal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ataque(){
		gameObject.GetComponent<BoxCollider2D>().isTrigger=true;
	}
}
