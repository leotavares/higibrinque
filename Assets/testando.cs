using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class testando : MonoBehaviour {
	Text txt;
	int x=0;
	// Use this for initialization
	void Start () {
		txt = gameObject.GetComponent<Text>();
		txt.text="Score : ";
		Transform teste1 = gameObject.transform;
		String testado=teste1.GetComponent<Text>().text;
		Debug.Log(testado);

	}
	
	// Update is called once per frame
	void Update () {
		txt.text="Score : " +Input.acceleration.x;

	}
}
