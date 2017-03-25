using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FollowMouse : MonoBehaviour
{

    [SerializeField] private float damping;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = Input.mousePosition;
        targetPos.z = 5.0f;
        targetPos = Camera.main.ScreenToWorldPoint(targetPos);

        MoveToPosition(targetPos);
    }

    void MoveToPosition(Vector3 tp)
    {
        rb.velocity = (tp - transform.position) * damping;
    }
}
