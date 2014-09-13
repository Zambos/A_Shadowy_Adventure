
using UnityEngine;
using System.Collections;

public class ProjectileDissapear : MonoBehaviour {
	public Animator anim;

	void awake(){
		anim = this.GetComponent<Animator> ();
	}
	void OnTriggerEnter2D(Collider2D objects){
		if (objects.gameObject.tag == "projectile") {

						this.gameObject.SendMessage ("Damage", new HealthEvent (gameObject, objects.gameObject.GetComponent<Damage> ().damage));
						Destroy (objects.gameObject);
						Debug.Log ("Ouch");
		} else if (objects.gameObject.tag == "melee") {
			this.gameObject.SendMessage ("Damage", new HealthEvent (gameObject, objects.gameObject.GetComponent<Damage> ().damage));
			Debug.Log ("Ouch");
		}

	}
}
