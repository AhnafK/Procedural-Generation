using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    Rigidbody2D _rigidbody;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    

    public void OnMove(InputAction.CallbackContext context)
    {
        _rigidbody.velocity = context.ReadValue<Vector2>() * speed;
    }
}
