using UnityEngine;
using System.Collections;

public class activate : MonoBehaviour {
	public bool contato;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Mathf.Abs (transform.position.x - GameObject.Find ("player").GetComponent<Transform>().position.x) <= 10)
						contato = true;
				else
						contato = false;
	}


		
}
