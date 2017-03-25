using UnityEngine;
using UnityEngine.AI;

public class ControllerCrab : MonoBehaviour {
	private DialogManager dm;
	private GameObject shell;
	private GameObject canMoving;
	private GameObject ground;

	void Start()
    {
        dm = GameObject.Find("DialogManager").GetComponent<DialogManager>();
		shell = transform.Find("Shell").gameObject;
		canMoving = transform.Find("CanMoving").gameObject;
		ground = GameObject.Find("Ground");
    }

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "Can") {
			GameManager.canPickUpShell = true;
			other.gameObject.SetActive(false);
			canMoving.transform.position = other.transform.position;
            gameObject.GetComponent<NavMeshAgent>().speed = 0.8f;
			shell.transform.parent = ground.transform;
			canMoving.SetActive(true);
            dm.SetState("CrabMoveToCan");
			
        }
	}
}
