using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RockController : MonoBehaviour {

	float fallSpeed;
	float rotSpeed;
	GameObject gameobject;

	void Start () {
		this.fallSpeed = 0.01f + 0.1f * Random.value;
		this.rotSpeed = 5f + 3f * Random.value;
	}

	void Update () {
		transform.Translate( 0, -fallSpeed, 0, Space.World);
		transform.Rotate(0, 0, rotSpeed );

		if (transform.position.y < -5.5f) {
			GameObject.Find ("GameOverManager").GetComponent<STGGameOver>().ChangeGameOver();
			Destroy (gameObject);
		}
	}
}