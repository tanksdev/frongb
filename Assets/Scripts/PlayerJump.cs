using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody capsuleRigidbody;
    private PlayerInput playerInput;

    private void Awake()
    {
        capsuleRigidbody = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();

        PlayerInputs playerInputs = new PlayerInputs();
        playerInputs.Player.Enable();
        playerInputs.Player.Jump.performed += Jump;
    }
    public void Jump(InputAction.CallbackContext context)
    {
        Debug.Log(context);
        if (context.performed)
        {
            Debug.Log("Jump" + context.phase);
            capsuleRigidbody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
    }
}
