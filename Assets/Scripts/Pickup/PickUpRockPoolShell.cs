using UnityEngine;

public class PickUpRockPoolShell : MonoBehaviour {

	void OnCollisionStay(Collision other)
	{
		Debug.Log( other.gameObject.name );
	}
}
