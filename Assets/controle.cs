using UnityEngine;
using System.Collections;

public class controle : MonoBehaviour {
	static public bool botaoRecieve=true;
	public float velX=1;
	public float velY=1;
	static public int j=0;
	bool jump=false;
	public bool grounded;
	Transform ground;
	public GameObject t;
	GameObject m;

	void Start(){
		m=GameObject.Find("check");
		if(t==null){
			Debug.Log("null");
			t=GameObject.Find("hero 1");}
		//GameObject.Instantiate(t,gameObject.transform.localPosition,gameObject.transform.localRotation);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float x=Input.GetAxis("Horizontal")*10;
		ground=transform.Find("check");
		grounded= Physics2D.Linecast(transform.position,ground.position,1 << LayerMask.NameToLayer("Ground"));
		rigidbody2D.AddForce(new Vector2(x,0));

		if(grounded){
			float y=Input.GetAxis("Vertical");
			rigidbody2D.AddForce(new Vector2(0,y*10));
		}

		if(Input.GetKey("p")){
			rigidbody2D.velocity= new Vector2(10,0);
		}
	


	}
		//Debug.Log (rigidbody2D.velocity.y);
				
	void Update(){
		if(grounded){
		if(Input.acceleration.x<=0.94f||Input.acceleration.x>=-0.94f){
			if(Input.acceleration.y<0)
			j=0;
		}
		if(Input.acceleration.x<=-0.95f){
			j=1;
		}
		if(Input.acceleration.x<=0.94f||Input.acceleration.x>=-0.94f){
			if(Input.acceleration.y>0)
				j=2;
		}
		if(Input.acceleration.x>=0.95f){
			j=3;
			}}

		switch(j){
		case 0:
			m.transform.position=new Vector3(gameObject.transform.position.x,gameObject.transform.position.y-4.5f);
			break;
		case 1:
			m.transform.position=new Vector3(gameObject.transform.position.x-4.5f,gameObject.transform.position.y);
			break;
		case 2:
			m.transform.position=new Vector3(gameObject.transform.position.x,gameObject.transform.position.y+4.5f);
			break;
		case 3:
			m.transform.position=new Vector3(gameObject.transform.position.x+4.5f,gameObject.transform.position.y);
			break;
		default:
			break;}
		testinho();
		rotateHero();
	}
	
	public void testinho(){
		switch(j){
			case 0:
			if(grounded==false)
				rigidbody2D.velocity=new Vector2(rigidbody2D.velocity.x,velY--);
			else{
				rigidbody2D.velocity=new Vector2(rigidbody2D.velocity.x,0);
				velY=0.1f;
			}
			break;
		case 1:
			if(grounded==false)
				rigidbody2D.velocity=new Vector2(velX--,rigidbody2D.velocity.y);
			else{
				rigidbody2D.velocity=new Vector2(0,rigidbody2D.velocity.y);
				velX=0.1f;
			}
			break;
		case 2:
			if(grounded==false)
				rigidbody2D.velocity=new Vector2(rigidbody2D.velocity.x,velY++);
			else{
				rigidbody2D.velocity=new Vector2(rigidbody2D.velocity.x,0);
				velY=-0.1f;
			}
			break;
		case 3:
			if(grounded==false)
				rigidbody2D.velocity=new Vector2(velX++,rigidbody2D.velocity.y);
			else{
				rigidbody2D.velocity=new Vector2(0,rigidbody2D.velocity.y);
				velX=-0.1f;
			}
			break;
		}
}

	void rotateHero(){
		switch(j){
		case 0:
			if(gameObject.transform.rotation.z!=0)
				gameObject.transform.rotation=new Quaternion(0,0,0,0);
			
			break;
		case 1:
			if(gameObject.transform.rotation.z!=-90)
				gameObject.transform.rotation=new Quaternion(0,0,-90,90);
			break;
		case 2:
			if(gameObject.transform.rotation.z!=180)
				gameObject.transform.rotation=new Quaternion(0,0,180,0);
			break;
		case 3:
			if(gameObject.transform.rotation.z!=-270)
				gameObject.transform.rotation=new Quaternion(0,0,-270,-270);
			break;
		}
	}

}