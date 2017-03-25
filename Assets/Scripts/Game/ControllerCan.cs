using UnityEngine;

public class ControllerCan : MonoBehaviour
{
    private DialogManager dm;

    void Start()
    {
        dm = GameObject.Find("DialogManager").GetComponent<DialogManager>();
    }

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.SetActive(false);

            dm.SetState("can");

            GameManager.hasCan = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        // dm.SetState("empty");
    }
}
