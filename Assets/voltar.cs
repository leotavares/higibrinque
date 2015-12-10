using UnityEngine;
using System.Collections;

public class voltar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void volt(){
		PlayerPrefs.SetInt("nivelAcabou",2);
		Application.LoadLevel(0);
	}

	public void leo(){
		Application.OpenURL ("https://www.facebook.com/RoboCOE");
	}

	public void robotech(){
		Application.OpenURL ("https://www.facebook.com/leonardo.tavares.9");
	}
}
