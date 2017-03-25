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
                if (hitInfo.transform.gameObject.name == "Shell")
                {
                    dm.SetState("CrabWithShell");
                }
            }
        }
    }
}