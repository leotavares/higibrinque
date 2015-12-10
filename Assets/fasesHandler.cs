using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fasesHandler : MonoBehaviour {
	public int fase1,fase2,fase3,fase4,fase5,nFase;
	public Sprite f1,f2,f3,f4,f5,fB,fF;
	// Use this for initialization
	void Start () {
		desbloquearFases();
		f1Star();
		f2Star();
		f3Star();
		f4Star();
		f5Star();
	}
	
	// Update is called once per frame
	void Update () {
		if(nFase!=PlayerPrefs.GetInt("nFase")){
			nFase=PlayerPrefs.GetInt("nFase");
			desbloquearFases();}
		if(fase1!=PlayerPrefs.GetInt("stars1")){
			fase1=PlayerPrefs.GetInt("stars1");
			f1Star();
		}
		if(fase2!=PlayerPrefs.GetInt("stars2")){
			fase2=PlayerPrefs.GetInt("stars2");
			f2Star();
		}
		if(fase3!=PlayerPrefs.GetInt("stars3")){
			fase3=PlayerPrefs.GetInt("stars3");
			f3Star();
		}
		if(fase4!=PlayerPrefs.GetInt("stars4")){
			fase4=PlayerPrefs.GetInt("stars4");
			f4Star();
		}
		if(fase5!=PlayerPrefs.GetInt("stars5")){
			fase5=PlayerPrefs.GetInt("stars5");
			if(nFase>=5)
			f5Star();
		}
	}

	public void desbloquearFases(){
		switch(nFase){
		case 0:
			fase1S(true);
			fase2S(false);
			fase3S(false);
			fase4S(false);
			fase5S(false);
			break;
		case 1:
			fase1S(true);
			fase2S(false);
			fase3S(false);
			fase4S(false);
			fase5S(false);
			break;
		case 2:
			fase1S(true);
			fase2S(true);
			fase3S(false);
			fase4S(false);
			fase5S(false);
			break;
		case 3:
			fase1S(true);
			fase2S(true);
			fase3S(true);
			fase4S(false);
			fase5S(false);
			break;
		case 4:
			fase1S(true);
			fase2S(true);
			fase3S(true);
			fase4S(true);
			fase5S(false);
			break;
		case 5:
			fase1S(true);
			fase2S(true);
			fase3S(true);
			fase4S(true);
			fase5S(true);
			break;
		}
	}
	public void fase1S(bool st){
		if(st==true){
			GameObject.Find("fase1").GetComponent<Image>().sprite=f1;
		}
		else{
			GameObject.Find("fase1").GetComponent<Image>().sprite=fB;
		}
	}
	public void fase2S(bool st){
		if(st==true){
			GameObject.Find("fase2").GetComponent<Image>().sprite=f2;
		}
		else{
			GameObject.Find("fase2").GetComponent<Image>().sprite=fB;
		}
	}
	public void fase3S(bool st){
		if(st==true){
			GameObject.Find("fase3").GetComponent<Image>().sprite=f3;
		}
		else{
			GameObject.Find("fase3").GetComponent<Image>().sprite=fB;
		}
	}
	public void fase4S(bool st){
		if(st==true){
			GameObject.Find("fase4").GetComponent<Image>().sprite=f4;
		}
		else{
			GameObject.Find("fase4").GetComponent<Image>().sprite=fB;
		}
	}
	public void fase5S(bool st){
		if(st==true){
			GameObject.Find("fase5").GetComponent<Image>().sprite=f5;
		}
		else{
			GameObject.Find("fase5").GetComponent<Image>().sprite=fB;
		}
	}

	public void f1Star(){
		switch(fase1){
		case 0:
			GameObject.Find("star11").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star21").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star31").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star41").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star51").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 1:
			GameObject.Find("star11").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star21").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star31").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star41").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star51").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 2:
			GameObject.Find("star11").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star21").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star31").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star41").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star51").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 3:
			GameObject.Find("star11").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star21").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star31").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star41").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star51").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 4:
			GameObject.Find("star11").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star21").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star31").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star41").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star51").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 5:
			GameObject.Find("star11").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star21").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star31").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star41").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star51").GetComponent<Image>().color=new Color32(255,255,255,255);
			break;
		}
	}
	public void f2Star(){
		switch(fase2){
		case 0:
			GameObject.Find("star12").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star22").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star32").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star42").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star52").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 1:
			GameObject.Find("star12").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star22").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star32").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star42").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star52").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 2:
			GameObject.Find("star12").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star22").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star32").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star42").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star52").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 3:
			GameObject.Find("star12").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star22").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star32").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star42").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star52").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 4:
			GameObject.Find("star12").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star22").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star32").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star42").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star52").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 5:
			GameObject.Find("star12").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star22").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star32").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star42").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star52").GetComponent<Image>().color=new Color32(255,255,255,255);
			break;
		}
	}
	public void f3Star(){
		switch(fase3){
		case 0:
			GameObject.Find("star13").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star23").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star33").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star43").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star53").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 1:
			GameObject.Find("star13").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star23").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star33").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star43").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star53").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 2:
			GameObject.Find("star13").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star23").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star33").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star43").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star53").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 3:
			GameObject.Find("star13").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star23").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star33").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star43").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star53").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 4:
			GameObject.Find("star13").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star23").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star33").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star43").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star53").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 5:
			GameObject.Find("star13").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star23").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star33").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star43").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star53").GetComponent<Image>().color=new Color32(255,255,255,255);
			break;
		}
	}
	public void f4Star(){
		switch(fase4){
		case 0:
			GameObject.Find("star14").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star24").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star34").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star44").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star54").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 1:
			GameObject.Find("star14").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star24").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star34").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star44").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star54").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 2:
			GameObject.Find("star14").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star24").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star34").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star44").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star54").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 3:
			GameObject.Find("star14").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star24").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star34").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star44").GetComponent<Image>().color=new Color32(255,255,255,0);
			GameObject.Find("star54").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 4:
			GameObject.Find("star14").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star24").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star34").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star44").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star54").GetComponent<Image>().color=new Color32(255,255,255,0);
			break;
		case 5:
			GameObject.Find("star14").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star24").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star34").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star44").GetComponent<Image>().color=new Color32(255,255,255,255);
			GameObject.Find("star54").GetComponent<Image>().color=new Color32(255,255,255,255);
			break;
		}
	}
	public void f5Star(){
		if(fase5==0){
			GameObject.Find("fase5").GetComponent<Image>().sprite=f5;
		}
		else{
			GameObject.Find("fase5").GetComponent<Image>().sprite=fF;
		}
	}
}
