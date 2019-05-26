using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class escape : MonoBehaviour {

	//壁に関する記述

	public const int WALL_FRONT	= 1;	//前
	public const int WALL_RIGHT	= 2;	//右
	public const int WALL_BACK	= 3;	//後
	public const int WALL_LEFT	= 4;	//左

	//定数の定義:ボタンカラー
	public const int COLOR_GREEN = 0;	//緑
	public const int COLOR_RED = 1;		//赤
	public const int COLOR_BLUE = 2;	//青
	public const int COLOR_WHITE = 3;	//白

	public GameObject panelWalls;		//壁全体

	public GameObject buttonHammer;		//ボタン:トンカチ

	public GameObject imageHammerIcon;	//アイコン:トンカチ

	public GameObject buttonMessage;	//ボタン：メッセージ
	public GameObject buttonMessageText;//メッセージテキスト

	public GameObject[] buttonLamp = new GameObject[3];	//ボタン:金庫

	public Sprite[] buttonPicture = new Sprite[4];		//ボタンの絵

	public Sprite hammerPicture;						//トンカチの絵

	private int wallNo;						//現在の向いている方向
	private bool doesHaveHammer;			//トンカチを持っているか
	private int[] buttonColer = new int[3];	//金庫のボタン

	// Use this for initialization
	void Start () {
		wallNo = WALL_FRONT;			//スタート時は前を向く
		doesHaveHammer = false;			//スタート時はトンカチを所持していない

		buttonColer[0] = COLOR_GREEN;	//スタート時のボタン1は緑色
		buttonColer[1] = COLOR_RED;		//スタート時のボタン1は赤色
		buttonColer[2] = COLOR_BLUE;	//スタート時のボタン1は青色
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//金庫のボタン1をクリック
	public void PushButtonLamp1(){
		ChangeButtonColor(0);
	}

	//金庫のボタン2をクリック
	public void PushButtonLamp2(){
		ChangeButtonColor(1);
	}

	//金庫のボタン3をクリック
	public void PushButtonLamp3(){
		ChangeButtonColor(2);
	}
	
	//金庫のボタンの色を変える
	void ChangeButtonColor(int buttonNo){
		buttonColer[buttonNo]++;
		//白ののときにクリックすると緑に変更
		if(buttonColer[buttonNo] > COLOR_WHITE){
			buttonColer[buttonNo] = COLOR_GREEN;
		}

	//ボタンの画像を変更
	buttonLamp [buttonNo].GetComponent<Image>().sprite =
		buttonPicture[buttonColer[buttonNo]];
	}


	//メモをクリック
	public void PushButtonMemo(){
		DisplayMessage("エッフェル塔と書いてある。");
	}

	//メッセージをクリック
	public void PushButtonMessage(){
		buttonMessage.SetActive(false);	//メッセージの削除
	}

	//右ボタンを押したとき
	public void PushButtonRight(){
		wallNo++;	//一つ右に移動
		//左の一つ右は前
		if(wallNo > WALL_LEFT){
			wallNo = WALL_FRONT;
		}
		DisplayWall();
	}

		//左ボタンを押したとき
	public void PushButtonLeft(){
		wallNo--;	//一つ左に移動
		//前の一つ左は左
		if(wallNo < WALL_FRONT){
			wallNo = WALL_LEFT;
		}
		DisplayWall();
	}

	//メッセージを表示
	void DisplayMessage(string mes){
		buttonMessage.SetActive(true);
		buttonMessageText.GetComponent<Text>().text = mes;
	}

	//向いている方向の壁を表示
	void DisplayWall(){
		switch (wallNo)
		{
			case WALL_FRONT:	//前
				panelWalls.transform.localPosition = new Vector3 (0.0f,0.0f,0.0f);
				break;

			case WALL_RIGHT:	//右
				panelWalls.transform.localPosition = new Vector3 (-1000.0f,0.0f,0.0f);
				break;

			case WALL_BACK:	//後
				panelWalls.transform.localPosition = new Vector3 (-2000.0f,0.0f,0.0f);
				break;

			case WALL_LEFT:	//左
				panelWalls.transform.localPosition = new Vector3 (-3000.0f,0.0f,0.0f);
				break;
		}
	}
}
