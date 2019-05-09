using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STGGameOver : MonoBehaviour {

public GameObject gameover;

	void Start () {
		gameover.SetActive(false);
    }

	public void ChangeGameOver(){
		gameover.SetActive(true);
    }

}
