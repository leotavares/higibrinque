using UnityEngine;
using System.Collections;

public class colorBar : MonoBehaviour {
	public float vida;
	public float vidaTotal;
	public int percent=10;
	public GameObject enemy;

	bool first=true;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (first) {
			vidaTotal=enemy.GetComponent<controlEnemy> ().vida;
			first=false;
				}
		vida = enemy.GetComponent<controlEnemy> ().vida;
		percent = (int)((vida / vidaTotal) * 10);
		switch (percent) {
		case 10:
			transform.localScale= new Vector3(1f,1f,1f);
			break;
		case 9:
			transform.localScale= new Vector3(0.9f,1f,1f);
			break;
		case 8:
			transform.localScale= new Vector3(0.8f,1f,1f);
			break;
		case 7:
			transform.localScale= new Vector3(0.7f,1f,1f);
			break;
		case 6:
			transform.localScale= new Vector3(0.6f,1f,1f);
			break;
		case 5:
			transform.localScale= new Vector3(0.5f,1f,1f);
			break;
		case 4:
			transform.localScale= new Vector3(0.4f,1f,1f);
			break;
		case 3:
			transform.localScale= new Vector3(0.3f,1f,1f);
			break;
		case 2:
			transform.localScale= new Vector3(0.2f,1f,1f);
			break;
		case 1:
			transform.localScale= new Vector3(0.1f,1f,1f);
			break;
		case 0:
			transform.localScale= new Vector3(0f,1f,1f);
			break;
		default:
			break;
		}
	}
}
