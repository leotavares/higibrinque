using UnityEngine;
using System.Collections;

public class controlEnemy : MonoBehaviour {
	public float constVida;
	public float porc;
	public float vida;
	public GameObject obj;
	public GameObject cura;
	public GameObject contact;
	// Use this for initialization
	void Start () {
		vida = constVida;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (contact.GetComponent<activate>().contato) {
						if (gameObject.transform.position.x - GameObject.Find ("player").transform.position.x > 0) {
								if (gameObject.transform.localScale.x != 0.15f)
										gameObject.transform.localScale = new Vector3 (0.15f, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
								if(gameObject.rigidbody2D.velocity.x>-4)
									gameObject.rigidbody2D.AddForce (new Vector2 (-20, 0));
								//gameObject.rigidbody2D.velocity = new Vector2 (-6, gameObject.rigidbody2D.velocity.y);
						} else {
								if (gameObject.transform.localScale.x != -0.15f)
										gameObject.transform.localScale = new Vector3 (-0.15f, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
								if(gameObject.rigidbody2D.velocity.x<4)
									gameObject.rigidbody2D.AddForce (new Vector2 (20, 0));
						}
				}
	}

	void OnTriggerEnter2D(Collider2D collision) {
		Debug.Log(collision.gameObject.name);
		if (collision.gameObject.name == "maoEscova1") {						
						vida = vida - (constVida * (float)(porc / 100));
			if(vida<=0){
				Instantiate(obj,gameObject.transform.position, Quaternion.identity);
				Instantiate(cura,gameObject.transform.position, Quaternion.identity);
				Destroy(gameObject);}
			Debug.Log (vida);
			if (gameObject.transform.localScale.x >= 0){
				gameObject.rigidbody2D.AddForce (new Vector2 (700, 100));
			}
			else{
				gameObject.rigidbody2D.AddForce (new Vector2 (-700, 100));
			}
				}
		if (collision.gameObject.name == "check") {						
			GameObject.Find("player").GetComponent<Rigidbody2D>().AddForce(new Vector2(0,300));
			vida = vida - (constVida * (float)(porc / 100));
			if(vida<=0){
				Instantiate(obj,gameObject.transform.position, Quaternion.identity);
				Instantiate(cura,gameObject.transform.position, Quaternion.identity);
				Destroy(gameObject);}
		}
	}

	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.name == "player") {
			GameObject.Find("hud").GetComponent<nomeCarregar>().vida-=1;
						if (gameObject.transform.localScale.x >= 0){
								coll.gameObject.rigidbody2D.AddForce (new Vector2 (-300, 100));
						}
						else{
								coll.gameObject.rigidbody2D.AddForce (new Vector2 (300, 100));
						}

				}
						

		}

}

	