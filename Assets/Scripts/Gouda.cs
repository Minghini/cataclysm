using UnityEngine;
using System.Collections;

public class Gouda : MonoBehaviour 

{
	//Properties
	private int _Integrity;

	public int Integrity 
	{
		get { return _Integrity;}
	}


	//Constructor
	public Gouda()
	{
		_Integrity = 3;
	}


	//Methods
	void OnTriggerEnter2D (Collider2D Other)
	{

		if (_Integrity > 0)
		{
			_Integrity--;
			print("Take bite");
		}else
		{
			GameObject.Destroy(this.gameObject);
		}	
	}
}
