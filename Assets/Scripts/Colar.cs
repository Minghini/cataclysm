using UnityEngine;
using System.Collections;

public class Colar : MonoBehaviour {

	public Transform refGuide;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector2.Lerp(GetComponent<Rigidbody2D>().position, refGuide.position,0);
	
	}
}
