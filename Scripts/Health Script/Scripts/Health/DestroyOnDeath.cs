using UnityEngine;
using System.Collections;

[AddComponentMenu("Health/Destroy On Death")]
public class DestroyOnDeath : MonoBehaviour {

	/// <summary>
	/// The object that will be destroyed on death
	/// </summary>
	public GameObject destroyThis = null;
	public Animator anim;
	public float deathLength;
	void Reset() {
		destroyThis = gameObject;
		anim = gameObject.GetComponent<Animator> ();
	}

	public IEnumerator OnDeath(HealthEvent health) {
		anim.SetTrigger("Death");
		yield return new WaitForSeconds (deathLength);
		Destroy(destroyThis);
	}
}
