using UnityEngine;
using System.Collections;
[RequireComponent(typeof(PlayerPhysics))]
public class PlayerController : MonoBehaviour {


	public float gravity = 20;
	public float speed = 8;
	public float acceleration = 100;
	public float jumpHeight = 12;
	public GameObject Slash;
	private float currentSpeed;
	private float targetSpeed;
	private Vector2 amountToMove;
	private float timeSinceLastAttack = 0.3f;
	private bool attacking= false;
	public PlayerPhysics playerPhysics;
	public GameObject lazer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Left")) {
			targetSpeed = -speed;

		} else if (Input.GetButton("Right")) {
			targetSpeed = speed;

		} else {
			targetSpeed = 0;

		}
		currentSpeed = IncrementTowards (currentSpeed,targetSpeed,acceleration);
		if (Input.GetButtonDown ("Fire2")) {
			if (timeSinceLastAttack > 0.7) {
				GameObject childObject = Instantiate (Slash, new Vector2 (this.transform.position.x + 0.3f, this.transform.position.y), new Quaternion (180, 0, 0, 0))
				as GameObject;
				childObject.transform.parent = this.transform;
				timeSinceLastAttack = 0;
			}
		}
		if (timeSinceLastAttack < 0.3) {
			attacking = true;
			currentSpeed = 0;
		} else {
			attacking = false;
		}
		if (Input.GetAxis("Fire1")==1 && timeSinceLastAttack>0.05){
			Instantiate(lazer, new Vector2 (this.transform.position.x + 0.3f, this.transform.position.y),Quaternion.identity);
			timeSinceLastAttack=0;
		}
		timeSinceLastAttack += Time.deltaTime;
		if (playerPhysics.grounded) {
			amountToMove.y=0;
			if (Input.GetButtonDown("Jump")){
				amountToMove.y = jumpHeight;
			}
		}

		if (playerPhysics.movementStop) {
			targetSpeed=0;
			currentSpeed = 0;
		}
		amountToMove.x = currentSpeed;
		amountToMove.y -= gravity * Time.deltaTime;
		playerPhysics.Move (amountToMove * Time.deltaTime);
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