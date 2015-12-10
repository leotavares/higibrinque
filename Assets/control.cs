using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {
	public int x=0;
	public int points=0;
	public bool grounded;
	public bool pulo = true;
	public int andarLado=0;
	Transform ground;
	protected Animator animator;
	public GameObject mao;
	// Use this for initialization
	void Start () {
		//gameObject.rigidbody2D.velocity = new Vector2 (2, gameObject.rigidbody2D.velocity.y);
		animator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		//gameObject.rigidbody2D.velocity = new Vector2 (2, gameObject.rigidbody2D.velocity.y);
		if(animator.GetCurrentAnimatorStateInfo(0).nameHash==-654031206){
			if(mao.GetComponent<BoxCollider2D>().isTrigger==false)
			mao.GetComponent<BoxCollider2D>().isTrigger=true;
		}else if(mao.GetComponent<BoxCollider2D>().isTrigger==true)
			mao.GetComponent<BoxCollider2D>().isTrigger=false;

	}

	void FixedUpdate(){
				
				ground = transform.Find ("check");
				grounded = Physics2D.Linecast (transform.position, ground.position, 1 << LayerMask.NameToLayer ("Ground"));
				if (grounded&&pulo)
					x = 0;	
		if(andarLado==1)
			andarDireita();
		if(andarLado==2)
			andarEsquerda();

	}

	public void pular(){

		if (x ==0) {
			pulo = false;
			animator.SetTrigger("pulo");
			x++;
			gameObject.rigidbody2D.velocity = new Vector2 (gameObject.rigidbody2D.velocity.x,12.5f );
			pulo=true;
		}

	}

	public void ataque(){
		animator.SetTrigger("ataque");

	}

	public void andD(){
		andarLado=1;
	}

	public void andE(){
		andarLado=2;
	}

	public void andarDireita(){
		if(gameObject.transform.localScale.x<0){
			gameObject.transform.position= new Vector2(gameObject.transform.position.x-1.72f,gameObject.transform.position.y);
			gameObject.transform.localScale= new Vector3(gameObject.transform.localScale.x*-1,gameObject.transform.localScale.y,gameObject.transform.localScale.z);}
		if(gameObject.rigidbody2D.velocity.x<5){							
			gameObject.rigidbody2D.AddForce (new Vector2 (30, 0));
			gameObject.GetComponent<Animator>().SetBool("andando",true);}
	}

	public void andarEsquerda(){
		if(gameObject.transform.localScale.x>=0){
			gameObject.transform.position= new Vector2(gameObject.transform.position.x+1.72f,gameObject.transform.position.y);
			gameObject.transform.localScale= new Vector3(gameObject.transform.localScale.x*-1,gameObject.transform.localScale.y,gameObject.transform.localScale.z);
		}
		if(gameObject.rigidbody2D.velocity.x>-5){							
			gameObject.rigidbody2D.AddForce (new Vector2 (-30, 0));
			gameObject.GetComponent<Animator>().SetBool("andando",true);}


	}

	public void pararAnim(){
		andarLado=0;
		gameObject.GetComponent<Animator> ().SetBool ("andando", false);
	}

	
	
}
