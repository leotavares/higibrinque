using UnityEngine;
using System.Collections;

public class curaEscova : MonoBehaviour {

	void Start () {
		gameObject.transform.position = new Vector2 (gameObject.transform.position.x, gameObject.transform.position.y + 1);
		gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 250));
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Player") {
			while(GameObject.Find("hud").GetComponent<nomeCarregar>().vida<10){
				GameObject.Find("hud").GetComponent<nomeCarregar>().vida++;}
			Destroy(gameObject);
		}
	}
}
