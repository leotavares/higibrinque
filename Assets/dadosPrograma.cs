using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class dadosPrograma : MonoBehaviour {
	Game test=Game.current;
	public int tes,tes2;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		tes = test.lvlMax;
	}
}
