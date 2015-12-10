using UnityEngine;
using System.Collections;

public class coinBreak : MonoBehaviour {
	public GameObject coin;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.name == "blockCoins") {
			Vector3 pos = collision.gameObject.transform.position;
			pos= new Vector3(pos.x,pos.y,pos.z);
			Quaternion quart =collision.gameObject.transform.rotation; 
			Destroy(collision.gameObject);
			Instantiate(coin,pos,quart);
		}
	}
}
