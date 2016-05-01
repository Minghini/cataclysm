using UnityEngine;
using System.Collections;

public class MoveCat : MonoBehaviour {

	public int catSpeed;
	public GameObject targetMouse;
	public Transform catColar;
	private float catAgility;
	private Vector2 catMovement;
	private Rigidbody2D catPhysics;
	bool chaseOn = true;
	
	// Use this for initialization
	void Start () {
	
		catPhysics = GetComponent<Rigidbody2D>();
		catColar = GameObject.Find("1st_link").transform;
	}
	
	// Update is called once per frame
	void Update () {

		catMovement = GetCatVelocity();

		// Move cat if alowwed to chase mouse
		if (chaseOn)
		{
			if (Vector2.Distance(catColar.position,catPhysics.transform.position) > 1)
			{

			}
			else
			{
			catPhysics.transform.position = new Vector2(catPhysics.transform.position.x + catMovement.x/catSpeed,
			                                            catPhysics.transform.position.y + catMovement.y/catSpeed);
			}
		}
	}
	Vector2 GetCatVelocity ()
	{
		Vector2 versor = new Vector2(targetMouse.transform.position.x-catPhysics.transform.position.x,
		                             targetMouse.transform.position.y - catPhysics.transform.position.y);
		versor.Normalize();
		return versor;
	}
	
}
