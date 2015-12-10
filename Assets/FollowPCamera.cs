using UnityEngine;
using System.Collections;

public class FollowPCamera : MonoBehaviour
{
	public Vector3 offset;			// The offset at which the Health Bar follows the player.
	
	private Transform player;		// Reference to the player.
	public GameObject play;
	public bool virar=false;

	
	

	
	void Update ()
	{
		player=GameObject.Find("player").transform;
		// Set the position to the player's position with the offset.
		if(play.GetComponent<control>().andarLado==1){
			if(virar)
				transform.position = new Vector3 (player.transform.position.x+1.72f, player.transform.position.y,-10);
			else
			transform.position = new Vector3 (player.transform.position.x, player.transform.position.y,-10);}
		if(play.GetComponent<control>().andarLado==2){
			transform.position = new Vector3 (player.transform.position.x-1.72f, player.transform.position.y,-10);
			virar=true;
		}
	}
}
