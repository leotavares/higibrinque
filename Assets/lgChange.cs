using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class lgChange : MonoBehaviour {

	public GameObject PanelMain,PanelPlay,PanelDemo,PanelSobre;
	string lg;
	public Sprite ballen,ballpt;
	public Sprite playen,playpt,demoen,demopt,abouten,aboutpt,namept,nameen;
	public Sprite deleteen,deletept,yesen,yespt,noen,nopt,asken,askpt;
	public Sprite sobreen,sobrept;
	public Sprite resuen,resupt,resten,restpt;
	// Use this for initialization

	void Start () {
		lg = PlayerPrefs.GetString ("lg");

		if (PlayerPrefs.GetString ("lg") == "pt") {
			mudarEnToPt(Application.loadedLevel);
		} else {
			mudarPtToEn(Application.loadedLevel);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (lg != PlayerPrefs.GetString ("lg")) {
			if (PlayerPrefs.GetString ("lg") == "pt") {
				mudarEnToPt(Application.loadedLevel);
			} else {
				mudarPtToEn(Application.loadedLevel);
			}

			lg=PlayerPrefs.GetString("lg");
		}
	}

	public void mudarPtToEn(int n){
		switch (n) {
		case 0:
			PanelPlay.SetActive (true);
			PanelDemo.SetActive (true);
			PanelSobre.SetActive (true);
			PanelMain.SetActive (true);

			GameObject.Find ("bolaLg").GetComponent<Image> ().sprite = ballen;
			GameObject.Find ("sobre").GetComponent<Image> ().sprite = abouten;
			GameObject.Find ("demo").GetComponent<Image> ().sprite = demoen;
			GameObject.Find ("jogar").GetComponent<Image> ().sprite = playen;

			GameObject.Find ("nomeText").GetComponent<Image> ().sprite = nameen;
			GameObject.Find ("Placeholder").GetComponent<Text>().text = "Type in your name";
			GameObject.Find ("botaoDelete").GetComponent<Image> ().sprite = deleteen;

			GameObject.Find ("areYou").GetComponent<Image> ().sprite = asken;
			GameObject.Find ("no").GetComponent<Image> ().sprite = noen;
			GameObject.Find ("yes").GetComponent<Image> ().sprite = yesen;

			PanelPlay.SetActive (false);
			PanelDemo.SetActive (false);
			PanelSobre.SetActive (false);
			PanelMain.SetActive (true);
			break;
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
			GameObject.Find ("resumir").GetComponent<Image> ().sprite = resuen;
			GameObject.Find ("reiniciar").GetComponent<Image> ().sprite = resten;
			break;

		case 7:
			GameObject.Find ("sobreImg").GetComponent<Image> ().sprite = sobreen;
			break;
		}
	}

	public void mudarEnToPt(int n){
		switch (n) {
		case 0:
			PanelPlay.SetActive (true);
			PanelDemo.SetActive (true);
			PanelSobre.SetActive (true);
			PanelMain.SetActive (true);

			GameObject.Find ("bolaLg").GetComponent<Image> ().sprite = ballpt;
			GameObject.Find ("sobre").GetComponent<Image> ().sprite = aboutpt;
			GameObject.Find ("demo").GetComponent<Image> ().sprite = demopt;
			GameObject.Find ("jogar").GetComponent<Image> ().sprite = playpt;
			
			GameObject.Find ("nomeText").GetComponent<Image> ().sprite = namept;
			GameObject.Find ("Placeholder").GetComponent<Text>().text = "Digite seu nome";
			GameObject.Find ("botaoDelete").GetComponent<Image> ().sprite = deletept;
			
			GameObject.Find ("areYou").GetComponent<Image> ().sprite = askpt;
			GameObject.Find ("no").GetComponent<Image> ().sprite = nopt;
			GameObject.Find ("yes").GetComponent<Image> ().sprite = yespt;

			PanelPlay.SetActive (false);
			PanelDemo.SetActive (false);
			PanelSobre.SetActive (false);
			PanelMain.SetActive (true);
			break;

		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
			GameObject.Find ("resumir").GetComponent<Image> ().sprite = resupt;
			GameObject.Find ("reiniciar").GetComponent<Image> ().sprite = restpt;
			break;

		case 7:
			GameObject.Find ("sobreImg").GetComponent<Image> ().sprite = sobrept;
			break;
		}
	}
}
