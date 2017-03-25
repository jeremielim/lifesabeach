using UnityEngine;

public class ControllerCan : MonoBehaviour
{
    private DialogManager dm;

    void Start()
    {
        dm = GameObject.Find("DialogManager").GetComponent<DialogManager>();
    }

    // void OnTriggerEnter(Collider other)
    // {
    //     if(other.gameObject.name == "Shell") {
    //         other.gameObject.GetComponent<NavMeshAgent>().speed = 0;
    //         dm.SetState("CrabMoveToCan");
    //     }
    // }

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.SetActive(false);
            dm.SetState("can");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        // dm.SetState("empty");
    }
}
