using UnityEngine;

public class GameManager : MonoBehaviour {
	public static bool canPickUpShell;

	void Awake()
	{
		canPickUpShell = false;
	}
}
