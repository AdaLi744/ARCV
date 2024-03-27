using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private InputActionReference moveActionInUse;
    [SerializeField]
    public float speed;

    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveDirection = moveActionInUse.action.ReadValue<Vector2>();
        Vector3 move = new Vector3(moveDirection.x, 0, moveDirection.y);
        rb.MovePosition(rb.position + (move * speed * Time.deltaTime));
    }
}
