using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuData : MonoBehaviour {
	public GameObject PanelMain,PanelPlay,PanelDemo,PanelSobre,PanelBack,background;
	public RuntimeAnimatorController idleMenu;
	public InputField field;
	public Sprite ballpt, ballen;
	bool first=false;
	// Use this for initialization
	void Start () {
		Debug.Log ("lg: "+PlayerPrefs.GetString ("lg"));

		if (PlayerPrefs.GetString ("lg") == "") {
						PlayerPrefs.SetString ("lg", "pt");
						Debug.Log ("lg: " + PlayerPrefs.GetString ("lg"));
				}

		Debug.Log(PlayerPrefs.GetInt("salvo"));
		PanelPlay.SetActive (false);
		PanelDemo.SetActive (false);
		PanelSobre.SetActive (false);
		PanelBack.SetActive (false);
		Debug.Log (PlayerPrefs.GetInt ("stars5"));
		if (PlayerPrefs.GetInt ("stars5") == 1)
						GameObject.Find ("trofeu").GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
		if (PlayerPrefs.GetInt ("nivelAcabou") == 1) {
			PlayerPrefs.SetInt("nivelAcabou",0);
			menuIdle();
			BotaoDemo();
			PanelBack.SetActive (true);
		}if (PlayerPrefs.GetInt ("nivelAcabou") == 2) {
			PlayerPrefs.SetInt("nivelAcabou",0);
			menuIdle();
		}


	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("trofeu")) {
			Debug.Log("not null");
						if (PlayerPrefs.GetInt ("stars5") == 1)
								GameObject.Find ("trofeu").GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
						else {
								GameObject.Find ("trofeu").GetComponent<Image> ().color = new Color32 (255, 255, 255, 0);
						}
				}

		if (first == false) {
			if (PanelMain.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).nameHash == -2052648280) {
						} else {
							menuIdle();
						}
		}
		if (PanelMain.activeSelf == false && PanelBack.activeSelf == false) {
			PanelBack.SetActive(true);
			Debug.Log("on");

				}
		if (PanelMain.activeSelf == true && PanelBack.activeSelf == true) {
			PanelBack.SetActive(false);
			Debug.Log("off");
		}


	}

	public void BotaoPlay(){
		PanelMain.SetActive (false);
		if(PlayerPrefs.GetInt("salvo")==0){
			PanelPlay.SetActive (true);
			Debug.Log("Play");}
		if(PlayerPrefs.GetInt("salvo")==1){
			PanelDemo.SetActive(true);
			Debug.Log("demo");}
	}

	public void botDemoVoz(){
		Application.LoadLevel (6);
		}
	public void BotaoDemo(){
		PanelMain.SetActive (false);
		PanelPlay.SetActive (false);
		PanelDemo.SetActive (true);
	}
	public void BotaoSobre(){
		Application.LoadLevel (7);
	}

	public void BotaoBack(){
		PanelPlay.SetActive (false);
		PanelDemo.SetActive (false);
		PanelSobre.SetActive (false);
		PanelMain.SetActive (true);

	}

	public void carregar(){
		if(PlayerPrefs.GetString("nome")!=null){
			Debug.Log(PlayerPrefs.GetString("nome"));
		}
	}

	public void Salvar(){
		PlayerPrefs.SetString("nome",field.text);
		PlayerPrefs.Save();
			if(field.text==""){
				GameObject.Find("tiaoBotao").GetComponent<Image>().color=new Color32(255,255,255,150);
				GameObject.Find("tinaBotao").GetComponent<Image>().color=new Color32(255,255,255,150);
			}else{
				GameObject.Find("tiaoBotao").GetComponent<Image>().color=new Color32(255,255,255,255);
				GameObject.Find("tinaBotao").GetComponent<Image>().color=new Color32(255,255,255,255);
			}
	}

	public void selecionarSexo(int n){
		if(GameObject.Find("nomeField").GetComponent<InputField>().text!=""){
			Debug.Log(n);
			PlayerPrefs.SetInt("sexo",n);
			PlayerPrefs.SetInt("salvo",1);
			PlayerPrefs.SetInt("nFase",1);
			PlayerPrefs.SetInt("stars1",0);
			PlayerPrefs.SetInt("stars2",0);
			PlayerPrefs.SetInt("stars3",0);
			PlayerPrefs.SetInt("stars4",0);
			PlayerPrefs.SetInt("stars5",0);
			PlayerPrefs.Save();
			BotaoDemo();
		}
	}

	public void certeza(){
		PanelSobre.SetActive (true);
		GameObject.Find("fase1").GetComponent<Button>().interactable=false;
		GameObject.Find("fase2").GetComponent<Button>().interactable=false;
		GameObject.Find("fase3").GetComponent<Button>().interactable=false;
		GameObject.Find("fase4").GetComponent<Button>().interactable=false;
		GameObject.Find("fase5").GetComponent<Button>().interactable=false;
		GameObject.Find("botaoDelete").GetComponent<Button>().interactable=false;
	}

	public void opcao(bool apagar){
		if(apagar==true){
		PlayerPrefs.SetInt("salvo",0);
		PlayerPrefs.SetInt ("stars5", 0);
		PlayerPrefs.Save();
			voltarCerteza();
			BotaoBack();}else{
			voltarCerteza();
			PanelSobre.SetActive(false);
		}
	}

	public void voltarCerteza(){
		GameObject.Find("fase1").GetComponent<Button>().interactable=true;
		GameObject.Find("fase2").GetComponent<Button>().interactable=true;
		GameObject.Find("fase3").GetComponent<Button>().interactable=true;
		GameObject.Find("fase4").GetComponent<Button>().interactable=true;
		GameObject.Find("fase5").GetComponent<Button>().interactable=true;
		GameObject.Find("botaoDelete").GetComponent<Button>().interactable=true;
	}

	public void carregarFase(int fase){
		Debug.Log (fase);
		Debug.Log (PlayerPrefs.GetInt ("nFase"));

		if (fase <= PlayerPrefs.GetInt ("nFase")) {
			string nomeF="fase"+fase;
			Application.LoadLevel(nomeF);
				}
	}
	public void menuIdle(){
		Color cor =background.GetComponent<Image>().color;
		first = true;
		PanelMain.GetComponent<Animator>().runtimeAnimatorController=idleMenu;
		background.GetComponent<Image>().color= new Color(cor.r,cor.g,cor.b,255f);
	}

	public void mudarLg(){
		if (PlayerPrefs.GetString ("lg") == "pt") {
						GameObject.Find ("bolaLg").GetComponent<Image> ().sprite = ballen;
						PlayerPrefs.SetString ("lg", "en");
				} else {
			GameObject.Find ("bolaLg").GetComponent<Image> ().sprite = ballpt;
			PlayerPrefs.SetString ("lg", "pt");
				}
	}
}
