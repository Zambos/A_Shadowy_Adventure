using UnityEngine;
using System.Collections;

public class MovingLazer : MonoBehaviour {
	public Transform lazer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		lazer.transform.Translate(Vector3.right*5);

	}
}
