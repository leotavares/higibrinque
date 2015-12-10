using UnityEngine;
using System.Collections;

public class coinsPoints : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.transform.position = new Vector2 (gameObject.transform.position.x, gameObject.transform.position.y + 1);
		gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 250));

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Player") {
			GameObject.Find("hud").GetComponent<nomeCarregar>().atualPoints++;
			Destroy(gameObject);
		}
	}
}
