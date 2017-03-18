using UnityEngine;

public class StickMover : MonoBehaviour
{
    [SerializeField] private int distanceFromCamera;
    [SerializeField] private float damping;
    private Rigidbody rb;
    private Vector3 startPos;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 targetPos = Input.mousePosition;
        targetPos.z = distanceFromCamera;
        targetPos = Camera.main.ScreenToWorldPoint(targetPos);

        // TODO
        // Stop stick if it has reach target position
        // Stop stick if it has rech start position


        if (rb.position.z > targetPos.z)
        {
            rb.velocity = Vector3.zero;
            rb.position = new Vector3( rb.position.x, rb.position.y, targetPos.z );
        }

        if (rb.position.x > targetPos.x)
        {
            rb.velocity = Vector3.zero;
            rb.position = new Vector3( targetPos.x, rb.position.y, rb.position.z );
        }

        // if (rb.position.z < startPos.z)
        // {
        //     rb.velocity = Vector3.zero;
        //     rb.position = new Vector3( rb.position.x, rb.position.y, targetPos.z );
        // }

        // if (rb.position.x < startPos.x)
        // {
        //     rb.velocity = Vector3.zero;
        //     rb.position = new Vector3( targetPos.x, rb.position.y, rb.position.z );
        // }

        if (Input.GetMouseButtonDown(0))
        {
            MoveToPosition(targetPos);
        }

        if (Input.GetMouseButtonUp(0))
        {
            MoveToPosition(startPos);
        }
    }

    bool IsMoving() {
        return true;
    }

    void MoveToPosition(Vector3 tp)
    {
        rb.velocity = (tp - transform.position) * damping;
    }

    void RotateToPoint(Vector3 tp)
    {
        rb.transform.eulerAngles = new Vector3(-90, Mathf.Atan2((tp.z - transform.position.z), (tp.x - transform.position.x)) * Mathf.Rad2Deg - 90, 0);
    }
}
