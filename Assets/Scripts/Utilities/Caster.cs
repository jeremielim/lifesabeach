using UnityEngine;

public class Caster : MonoBehaviour
{
    [SerializeField] private float distance;
    [SerializeField] private Vector3 direction;
    [SerializeField] private float force;

    void Update()
    {
        RaycastHit hit;

        Debug.DrawRay(transform.position, direction * distance, Color.green);

        if (Physics.Raycast(transform.position, direction * distance, out hit, distance))
            if (hit.transform.gameObject.layer == LayerMask.NameToLayer("CastCollider"))
            {
                Debug.Log(hit.transform.gameObject.name);
                hit.rigidbody.AddForceAtPosition(Vector3.forward * force, hit.point);
            }

            if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Consumable"))
            {
                //hit.transform.gameObject.GetComponent<Pickup>().PickUp();
            }
    }
}
