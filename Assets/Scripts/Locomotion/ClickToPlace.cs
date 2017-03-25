using UnityEngine;

public class ClickToPlace : MonoBehaviour
{

    private FollowMouse fm;
    private Rigidbody rb;

    void Start()
    {
        fm = GetComponent<FollowMouse>();
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fm.enabled = !fm.enabled;

            rb.velocity = Vector3.zero;
            transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
        }
    }
}
