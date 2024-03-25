using Unity.Netcode;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour
{
    [SerializeField] float speed = 25f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!IsOwner) return;
        float horizontal = Input.GetAxis("Horizontal");
        float forward = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, forward);
        rb.AddForce(movement * speed);


    }
}
