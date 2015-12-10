using UnityEngine;
using System.Collections;

public class terminarFase : MonoBehaviour {

	void FixedUpdate(){
		Debug.Log (gameObject.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).nameHash);
		}
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Player") {
			if(PlayerPrefs.GetInt("nFase")<=Application.loadedLevel){
				PlayerPrefs.SetInt("nFase",Application.loadedLevel+1);
			}
			gameObject.GetComponent<Animator>().SetTrigger("final");
			StartCoroutine( DoSomething());

		}
	}

	IEnumerator DoSomething()
	{

		yield return new WaitForSeconds(1.5f);
		PlayerPrefs.SetInt("nivelAcabou",1);
		Application.LoadLevel(0);
	}
}
