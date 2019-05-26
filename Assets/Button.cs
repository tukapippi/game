﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

	//　リスタートかシューティングボタンを押したら実行する
	public void shooting() {
		SceneManager.LoadScene ("STG");
	}

	//　リスタートかフラッピーボタンを押したら実行する
	public void flappy() {
		SceneManager.LoadScene ("STG");
	}

		//　リスタートか脱出を押したら実行する
	public void escape() {
		SceneManager.LoadScene ("脱出メニュー");
	}

	//　メニューボタンを押したら実行する
		public void Menu() {
		SceneManager.LoadScene ("Menu");
	}
}