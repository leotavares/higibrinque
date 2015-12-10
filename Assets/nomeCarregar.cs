using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class nomeCarregar : MonoBehaviour {
	public Sprite tina,tiao,corpoTina,corpoTiao,olhoTina,olhoTiao,cabeloE,cabeloD,cabelo;
	public GameObject corpo,cabelo1,cabelo2,olho,pausePanel,morte;
	public int vida=10;
	public int totalPoints=0;
	public int atualPoints=0;
	public int porc;
	public int demo=1;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		GameObject.Find("pausePanel").SetActive(false);
		morte.SetActive (false);
		if(PlayerPrefs.GetString("nome")!=null){
			GameObject.Find("nome").GetComponent<Text>().text=PlayerPrefs.GetString("nome");
		}
		Debug.Log (PlayerPrefs.GetInt ("sexo"));
		if(PlayerPrefs.GetInt("sexo")==1){
			GameObject.Find("fotoPersonagem").GetComponent<Image>().sprite=tina;
			corpo.GetComponent<SpriteRenderer>().sprite=corpoTina;
			cabelo1.GetComponent<SpriteRenderer>().sprite=cabeloE;
			cabelo2.GetComponent<SpriteRenderer>().sprite=cabeloD;
			olho.GetComponent<SpriteRenderer>().sprite=olhoTina;
			corpo.transform.localScale=new Vector3(1,1,1);

		}else{ GameObject.Find("fotoPersonagem").GetComponent<Image>().sprite=tiao;}
	
	}

	void Update(){
		if(totalPoints!=0)
		porc=(int)((atualPoints*5)/totalPoints);
		switch (vida) {
		case 10:
			GameObject.Find("vida").transform.localScale= new Vector3(1f,1f,1f);
			GameObject.Find("vida").transform.localPosition= new Vector2(152,-29);
			break;
		case 9:
			GameObject.Find("vida").transform.localScale= new Vector3(0.9f,1f,1f);
			GameObject.Find("vida").transform.localPosition= new Vector2(127,-29);
			break;
		case 8:
			GameObject.Find("vida").transform.localScale= new Vector3(0.8f,1f,1f);
			GameObject.Find("vida").transform.localPosition= new Vector2(102,-29);
			break;
		case 7:
			GameObject.Find("vida").transform.localScale= new Vector3(0.7f,1f,1f);
			GameObject.Find("vida").transform.localPosition= new Vector2(77,-29);
			break;
		case 6:
			GameObject.Find("vida").transform.localScale= new Vector3(0.6f,1f,1f);
			GameObject.Find("vida").transform.localPosition= new Vector2(52,-29);
			break;
		case 5:
			GameObject.Find("vida").transform.localScale= new Vector3(0.5f,1f,1f);
			GameObject.Find("vida").transform.localPosition= new Vector2(27,-29);
			break;
		case 4:
			GameObject.Find("vida").transform.localScale= new Vector3(0.4f,1f,1f);
			GameObject.Find("vida").transform.localPosition= new Vector2(2,-29);
			break;
		case 3:
			GameObject.Find("vida").transform.localScale= new Vector3(0.3f,1f,1f);
			GameObject.Find("vida").transform.localPosition= new Vector2(-23,-29);
			break;
		case 2:
			GameObject.Find("vida").transform.localScale= new Vector3(0.2f,1f,1f);
			GameObject.Find("vida").transform.localPosition= new Vector2(-48,-29);
			break;
		case 1:
			GameObject.Find("vida").transform.localScale= new Vector3(0.1f,1f,1f);
			GameObject.Find("vida").transform.localPosition= new Vector2(-72,-29);
			break;
		case 0:
			GameObject.Find("vida").transform.localScale= new Vector3(0f,1f,1f);
			fimFase();
			break;
		default:
			break;
		}

		if(porc!=PlayerPrefs.GetInt("stars"+Application.loadedLevel)){

			switch(porc){
			case 0:
				GameObject.Find("star1").GetComponent<Image>().color=new Color32(255,255,255,0);
				GameObject.Find("star2").GetComponent<Image>().color=new Color32(255,255,255,0);
				GameObject.Find("star3").GetComponent<Image>().color=new Color32(255,255,255,0);
				GameObject.Find("star4").GetComponent<Image>().color=new Color32(255,255,255,0);
				GameObject.Find("star5").GetComponent<Image>().color=new Color32(255,255,255,0);
				break;
			case 1:
				GameObject.Find("star1").GetComponent<Image>().color=new Color32(255,255,255,255);
				GameObject.Find("star2").GetComponent<Image>().color=new Color32(255,255,255,0);
				GameObject.Find("star3").GetComponent<Image>().color=new Color32(255,255,255,0);
				GameObject.Find("star4").GetComponent<Image>().color=new Color32(255,255,255,0);
				GameObject.Find("star5").GetComponent<Image>().color=new Color32(255,255,255,0);
				break;
			case 2:
				GameObject.Find("star1").GetComponent<Image>().color=new Color32(255,255,255,255);
				GameObject.Find("star2").GetComponent<Image>().color=new Color32(255,255,255,255);
				GameObject.Find("star3").GetComponent<Image>().color=new Color32(255,255,255,0);
				GameObject.Find("star4").GetComponent<Image>().color=new Color32(255,255,255,0);
				GameObject.Find("star5").GetComponent<Image>().color=new Color32(255,255,255,0);
				break;
			case 3:
				GameObject.Find("star1").GetComponent<Image>().color=new Color32(255,255,255,255);
				GameObject.Find("star2").GetComponent<Image>().color=new Color32(255,255,255,255);
				GameObject.Find("star3").GetComponent<Image>().color=new Color32(255,255,255,255);
				GameObject.Find("star4").GetComponent<Image>().color=new Color32(255,255,255,0);
				GameObject.Find("star5").GetComponent<Image>().color=new Color32(255,255,255,0);
				break;
			case 4:
				GameObject.Find("star1").GetComponent<Image>().color=new Color32(255,255,255,255);
				GameObject.Find("star2").GetComponent<Image>().color=new Color32(255,255,255,255);
				GameObject.Find("star3").GetComponent<Image>().color=new Color32(255,255,255,255);
				GameObject.Find("star4").GetComponent<Image>().color=new Color32(255,255,255,255);
				GameObject.Find("star5").GetComponent<Image>().color=new Color32(255,255,255,0);
				break;
			case 5:
				GameObject.Find("star1").GetComponent<Image>().color=new Color32(255,255,255,255);
				GameObject.Find("star2").GetComponent<Image>().color=new Color32(255,255,255,255);
				GameObject.Find("star3").GetComponent<Image>().color=new Color32(255,255,255,255);
				GameObject.Find("star4").GetComponent<Image>().color=new Color32(255,255,255,255);
				GameObject.Find("star5").GetComponent<Image>().color=new Color32(255,255,255,255);
				break;
			}
			PlayerPrefs.SetInt("stars"+Application.loadedLevel,porc);
		}
	}

	public void fimFase(){
		Time.timeScale = 0;
		morte.SetActive (true);
	}
	

	public void pause(bool paused){
		if (paused == false) {
			pausePanel.SetActive(true);
						Time.timeScale = 0;
						
				} else {
			Time.timeScale = 1;
			pausePanel.SetActive(false);
				}
	}

	public void botaoMenuR(int n){
		if (n == 0) {
			Time.timeScale = 1;
			Debug.Log(Time.timeScale);
			Application.LoadLevel(Application.loadedLevel);
				}
		if (n == 1) {
			Time.timeScale = 1;
			PlayerPrefs.SetInt("nivelAcabou",demo);
			Application.LoadLevel(0);
				}
	}
	// Update is called once per frame
}
