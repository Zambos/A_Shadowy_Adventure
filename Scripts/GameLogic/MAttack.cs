using UnityEngine;
using System.Collections;

public class MAttack : MonoBehaviour {
	Ray ray;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = this.GetComponent<Transform> ().position.x+0.1f;
		float y = this.GetComponent<Transform> ().position.y;
		ray = new Ray(new Vector2(x,y),new Vector2(1,0));
	}
}
