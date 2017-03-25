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
            gameObject.SetActive(false);

            if (gameObject.name == "Can")
            {
                dm.SetState("canPickup");
                GameManager.hasCan = true;
            }

            if (gameObject.name == "Stick")
            {
                dm.SetState("stickPickup");
                GameManager.hasStick = true;
            }
        }
    }
}
