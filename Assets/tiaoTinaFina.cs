using UnityEngine;
using System.Collections;

public class tiaoTinaFina : MonoBehaviour {
	public Sprite corpoTina,olhoTina,cabeloE,cabeloD;
	public GameObject corpo,cabelo1,cabelo2,olho;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("sexo")==1){
			corpo.GetComponent<SpriteRenderer>().sprite=corpoTina;
			cabelo1.GetComponent<SpriteRenderer>().sprite=cabeloE;
			cabelo2.GetComponent<SpriteRenderer>().sprite=cabeloD;
			olho.GetComponent<SpriteRenderer>().sprite=olhoTina;
			corpo.transform.localScale=new Vector3(1,1,1);
			
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
