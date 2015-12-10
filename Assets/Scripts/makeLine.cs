using UnityEngine;
using System.Collections;

public class makeLine : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position=Camera.main.ScreenToWorldPoint(Input.mousePosition);
		gameObject.GetComponent<LineRenderer>().SetPosition(1,gameObject.transform.position);
		gameObject.GetComponent<LineRenderer>().SetPosition(0,GameObject.Find("gunOut").transform.position);
	}

}
