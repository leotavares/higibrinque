using UnityEngine;
using System.Collections;

public class controlEscova : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = new Vector3 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x-2f, Camera.main.ScreenToWorldPoint (Input.mousePosition).y, 0);
	}


}
