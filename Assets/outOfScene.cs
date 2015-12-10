using UnityEngine;
using System.Collections;

public class outOfScene : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.name == "player") {						
			GameObject.Find("hud").GetComponent<nomeCarregar>().fimFase();
		}
		else{
			Destroy(collision.gameObject);
		}
	}
}
