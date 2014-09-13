using UnityEngine;
using System.Collections;

public class GameCamera : MonoBehaviour {

	public Transform target;
	private Vector3 lastTarget;
	public float trackSpeed = 10;
	public float minTrackSpeed = 10;
	public float trackAcc = 4;
	public float xWall;
	public float yWall;
	public GameObject player ;

	public void SetTarget(GameObject t){
		target = t.transform;
		player = t;
		lastTarget = new Vector3(t.transform.position.x,t.transform.position.y,-4);
	}

	void LateUpdate(){
			//Debug.Log (player.GetComponent<PlayerPhysics> ().grounded);
		//check if on ground
//		if (player.GetComponent<PlayerPhysics> ().grounded) {
//				if (target) {
//					lastTarget = target.position;
//					float x = IncrementTowards (transform.position.x, target.position.x, trackSpeed);
//					float y = IncrementTowards (transform.position.y, target.position.y, trackSpeed);
//					this.gameObject.transform.position = new Vector3 (x, y, -4);
//					Debug.Log ("going to " + x + " " + y + " " + this.transform.position + " " + this.gameObject.transform.localPosition);
//				}
//		}

		//checking X axis
		if (target) {
			 if (Mathf.Abs (player.transform.position.x - this.transform.position.x) > xWall) {
				lastTarget = target.position;
				float x = IncrementTowards (transform.position.x, target.position.x, trackSpeed);
				this.gameObject.transform.position = new Vector3 (x, this.transform.position.y, -4);
				//Debug.Log ("going to " + x + " " + " " + this.transform.position + " " + this.gameObject.transform.localPosition);
			}
		/* else {
				float x = IncrementTowards (transform.position.x, lastTarget.x, trackSpeed);
				float y = IncrementTowards (transform.position.y, lastTarget.y, trackSpeed);
				this.transform.position = new Vector3(x,y,-4);
			}*/


						//Checking Y axis
			if(player.GetComponent<PlayerPhysics>().grounded){
				if (Input.GetButton ("Down")) {
					lastTarget = target.position;
					float y = IncrementTowards (transform.position.y, transform.position.y -1f, trackSpeed);
					this.gameObject.transform.position = new Vector3 (this.transform.position.x, y, -4);
					yWall=1;
				}else{
					yWall=0;
				}
				if (Mathf.Abs (player.transform.position.y - this.transform.position.y) > yWall  ) {
					lastTarget = target.position;
					float y = IncrementTowards (transform.position.y, target.position.y+1, trackSpeed);
					this.gameObject.transform.position = new Vector3 (this.transform.position.x, y, -4);
					//Debug.Log ("going to " + " " + y + " " + this.transform.position + " " + this.gameObject.transform.localPosition);
				}
							/*else {
			float x = IncrementTowards (transform.position.x, lastTarget.x, trackSpeed);
			float y = IncrementTowards (transform.position.y, lastTarget.y, trackSpeed);
			this.transform.position = new Vector3(x,y,-4);		
		}*/
			}
		}
	}
		

	public float IncrementTowards(float n, float target, float a){
			if (n == target) {
				return n;
			}
			else{
				float dir = Mathf.Sign(target - n);
				n+=a*Time.deltaTime*dir;
			
				return (dir == Mathf.Sign(target-n))? n : target;
			}
		}	
}
