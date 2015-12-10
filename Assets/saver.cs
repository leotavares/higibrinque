using UnityEngine;
using System.Collections;

public class saver : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void carregar(){
		testSaver.Load ();
	}

	public void salvar(){
		testSaver.Save ();
	}

}
