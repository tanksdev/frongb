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
        //the player
        playerInput = GetComponent<PlayerInput>();
        //references input system

        playerInputs = new PlayerInputs();
        playerInputs.Player.Enable();
        //starts the player input script
        playerInputs.Player.Jump.performed += Jump;
        //reference the Jump input
        //playerInputs.Player.Movement.performed += Movement_performed;
    }
    private void Update()
    {
        Vector2 inputVector = playerInputs.Player.Movement.ReadValue<Vector2>();
        //vector2 because I dont want to float when I press w to go forward
        float speed  = 10f;
        //player speed
        sphereRigidbody.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
        //establishes player movement's axes
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
            //shows in console when the Jump action is started, performed, cancelled
            sphereRigidbody.AddForce(Vector3.up * 50f, ForceMode.Impulse);
            //activates on button press, brings player upwards
        }
    }
}
