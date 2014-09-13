	
	using UnityEngine;
using System.Collections;

public class LineOfSight : MonoBehaviour {
	public GameObject player;
	Ray ray;
	RaycastHit hit;
	// Update is called once per frame
	void Update () {
		ray = new Ray(transform.position,player.transform.position);
		Debug.DrawRay(ray.origin,ray.direction);
		if (Physics.Raycast (ray, out hit,2)) {
			Debug.Log("BANG!");
			if(hit.collider.gameObject.tag=="Player"){
				Debug.Log("BANG!");
			}		
		}


	}
}
