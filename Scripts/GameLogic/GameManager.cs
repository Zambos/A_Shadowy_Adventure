using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public GameObject player;
	public GameObject playerPrefab;
	public Transform spawnPoint;
	public GameCamera cam;
	// Use this for initialization
	void Start () {
		//cam = GetComponent<GameCamera>();
		SpawnPlayer ();

	}

	void Update(){
		Debug.Log (player.transform.position.y);
		if (player.transform.position.y<-11){
			Destroy (player);
			SpawnPlayer();
		}
	}
	private void SpawnPlayer(){
		player = (Instantiate (playerPrefab, spawnPoint.localPosition, Quaternion.identity) as GameObject);
		cam.SetTarget(player);
	}
}
