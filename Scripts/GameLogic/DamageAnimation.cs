using UnityEngine;
using System.Collections;

public class DamageAnimation : MonoBehaviour {
	Animator anim;
	public float DamageAnimationLength;
	void Awake(){
		anim = this.GetComponent<Animator>();

	}

	void OnDamaged(HealthEvent gotHit){
		anim.SetTrigger("Damage");
		//yield return new WaitForSeconds (DamageAnimationLength);
	}
}
