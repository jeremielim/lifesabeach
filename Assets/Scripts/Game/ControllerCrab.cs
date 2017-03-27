using UnityEngine;
using UnityEngine.AI;

public class ControllerCrab : MonoBehaviour {
	private DialogManager dm;
	private GameObject shell;
	private GameObject canWithCrab;
	private GameObject ground;

	void Start()
    {
        dm = GameObject.Find("DialogManager").GetComponent<DialogManager>();
		shell = transform.Find("Shell").gameObject;
		canWithCrab = transform.Find("CanWithCrab").gameObject;
		ground = GameObject.Find("Ground");
    }

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "CanFollowerPrefab") {
			GameManager.canPickUpShell = true;
			other.gameObject.SetActive(false);
			canWithCrab.transform.position = other.transform.position;
            gameObject.GetComponent<NavMeshAgent>().speed = 0.8f;
			shell.transform.parent = ground.transform;
			canWithCrab.SetActive(true);
            dm.SetState("CrabMoveToCan");
			
        }
	}
}
