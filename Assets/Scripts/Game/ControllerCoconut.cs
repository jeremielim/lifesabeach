using UnityEngine;

public class ControllerCoconut : MonoBehaviour
{	
    private DialogManager dm;

    void Start()
    {
        dm = GameObject.Find("DialogManager").GetComponent<DialogManager>();
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dm.SetState ( "coconut" );
        }
    }

    void OnTriggerExit(Collider other)
    {
        dm.SetState ( "empty" );
    }
}
