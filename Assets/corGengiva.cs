using UnityEngine;
using System.Collections;

public class corGengiva : MonoBehaviour {
	public int corT=0;
	public int corT1=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(corT!=corT1){
			if(corT<=120){
				corT1=corT;
				mudarCor();
				if(corT==120){
					GameObject.Find("animador").GetComponent<Animator>().SetTrigger("lutaFim");
					StartCoroutine( DoSomething());
				}
			}
			corT1=corT;
		}
	}

	void mudarCor(){
		
		byte teste=(byte)(corT*2.125f);
		GameObject.Find("cima").GetComponent<SpriteRenderer>().color= new Color32(255,255,255,teste);
		GameObject.Find("baixo").GetComponent<SpriteRenderer>().color= new Color32(255,255,255,teste);
	}

	IEnumerator DoSomething()
	{
		GameObject.Find("escovaMovimento").GetComponent<controlEscova>().enabled=false;
		Debug.Log ("teste");
		yield return new WaitForSeconds(5);
		PlayerPrefs.SetInt("nivelAcabou",1);
		PlayerPrefs.SetInt ("stars5", 1);
		Application.LoadLevel(0);
		Debug.Log ("teste");
	}
}
