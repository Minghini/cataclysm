using UnityEngine;
using System.Collections;

public class moveMouse : MonoBehaviour {

	//Set Mouse Speed between 0.08 to 0.2
	public float mouseSpeed;

	// Condition to move
	bool cheeseFound = false;

	// Set next Target
	GameObject targetCheese = null;

	// Mouse parameters;

	private Rigidbody2D mouseXY;

	// Use this for initialization
	void Start () {
	
		mouseXY = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		if(!cheeseFound)
		GetNextTargetCheese();

		if (targetCheese!=null)
		cheeseFound = true;

		if (cheeseFound){

			mouseXY.position = Vector2.Lerp(mouseXY.position, targetCheese.transform.position, mouseSpeed);
		
		}
	
	}

	private void GetNextTargetCheese (){
	
		//cheeseFound = false;

		targetCheese = GameObject.FindWithTag("cheese");

	}


	void OnTriggerEnter2D (Collider2D Other){

		if(Other.tag == "cheese"){
			cheeseFound = false;
			mouseXY.position = -1*Vector2.Lerp(mouseXY.position, targetCheese.transform.position, mouseSpeed);
		}
	
	}
}