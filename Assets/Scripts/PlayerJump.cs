using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody sphereRigidbody;
    private PlayerInput playerInput;
    private PlayerInputs playerInputs;

    private void Awake()
    {
        sphereRigidbody = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();

        playerInputs = new PlayerInputs();
        playerInputs.Player.Enable();
        playerInputs.Player.Jump.performed += Jump;
        //playerInputs.Player.Movement.performed += Movement_performed;
    }
    private void FixedUpdate()
    {
        Vector2 inputVector = playerInputs.Player.Movement.ReadValue<Vector2>();
        float speed  = 5f;
        sphereRigidbody.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
    }
 /*   private void Movement_performed(InputAction.CallbackContext context)
    {
        Debug.Log(context);
        Vector2 inputVector = context.ReadValue<Vector2>();
        float speed  = 5f;
        sphereRigidbody.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
    }*/
    public void Jump(InputAction.CallbackContext context)
    {
        Debug.Log(context);
        if (context.performed)
        {
            Debug.Log("Jump" + context.phase);
            sphereRigidbody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
    }
}
