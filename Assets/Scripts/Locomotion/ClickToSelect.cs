using UnityEngine;

public class ClickToSelect : MonoBehaviour
{
    RaycastHit hitInfo = new RaycastHit();
    private DialogManager dm;

    void Start()
    {
        dm = GameObject.Find("DialogManager").GetComponent<DialogManager>();
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
            {
                if (hitInfo.transform.gameObject.name == "ShellRockPool") {
                    hitInfo.transform.gameObject.SetActive(false);
                    dm.SetState("PickupShell");
                    GameManager.curShells += 1;
                } 
                if (hitInfo.transform.gameObject.name == "Shell")
                {

                    if (!GameManager.canPickUpShell)
                    {
                        dm.SetState("CrabWithShell");
                    }
                    else
                    {
                        dm.SetState("PickupShell");
                        hitInfo.transform.gameObject.SetActive(false);
                        GameManager.curShells += 1;
                    }
                }

                if(hitInfo.transform.gameObject.name == "Urchin") {
                    dm.SetState("PickupUrchin");
                }
            }
        }
    }
}