using UnityEngine;

public class PickUpObject : MonoBehaviour
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
            if (gameObject.layer == 8)
            {
                gameObject.SetActive(false);
            }

            if(gameObject.name == "ShellBeach")
            {
                GameManager.curShells += 1;
                gameObject.SetActive(false);
                dm.SetState("shellBeachPickup");
            }

            if (gameObject.name == "CanEmpty")
            {
                dm.SetState("canPickup");
                GameManager.hasCan = true;
            }

            if (gameObject.name == "Stick")
            {
                dm.SetState("stickPickup");
                GameManager.hasStick = true;
            }

            if (gameObject.name == "Coconut")
            {
                dm.SetState("coconutPickup");
            }
        }
    }
}
