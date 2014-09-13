using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {
	public float speed;
	private float timeLived;
	public float Life;
	// Use this for initialization
	void Start () {
		this.rigidbody2D.AddForce (new Vector2(2,0));
	}
	
	// Update is called once per frame
	void Update () {
		if (timeLived > Life)
						Destroy (this.gameObject);
		timeLived += Time.deltaTime;
		this.rigidbody2D.AddForce (new Vector2(2,0));
	}
}
