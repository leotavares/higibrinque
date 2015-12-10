using UnityEngine;
using System.Collections;

public class batalhaFina : MonoBehaviour {
	public bool batalha=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(GameObject.Find("animador").GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).nameHash);
		if(batalha==false&&GameObject.Find("animador").GetComponent<Animator>().GetCurrentAnimatorStateInfo (0).nameHash==1511492210){
			GameObject.Find("escovaMovimento").transform.position=GameObject.Find("escovaParada").transform.position;
			GameObject.Find("escovaParada").SetActive(false);
			GameObject.Find("escovaMovimento").GetComponent<controlEscova>().enabled=true;
			Debug.Log("fim");
			batalha=true;
		}
	}
}
