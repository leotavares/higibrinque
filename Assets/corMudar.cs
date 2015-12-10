using UnityEngine;
using System.Collections;

public class corMudar : MonoBehaviour {
	public int corT=0;
	public int corT1=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(corT!=corT1){
			if(corT<=20){
				mudarCor();
				}
			corT1=corT;
		}
	}

	void mudarCor(){

		byte teste=(byte)(corT*12.75);
		gameObject.GetComponent<SpriteRenderer>().color= new Color32(255,255,255,teste);
		GameObject.Find("tartaroideboss").GetComponent<corGengiva>().corT++;
	}
}
