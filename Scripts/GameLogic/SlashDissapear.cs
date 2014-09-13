using UnityEngine;
using System.Collections;

public class SlashDissapear : MonoBehaviour {

	public float DissapearTime = 1;
	private float livedTime = 0;
	// Update is called once per frame
	void Update () {
		//Debug.Log (Time.deltaTime + " "+ livedTime);
		livedTime += Time.deltaTime;
		if (livedTime >= DissapearTime)
						Destroy (this.gameObject);
	}
}
