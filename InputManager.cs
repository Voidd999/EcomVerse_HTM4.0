using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerMOvement playerControls;

    public AnimatorManager animManager;
    public Vector2 movementInput;
    private float moveAmount;

    public Vector2 cameraInput;
    public float cameraInputX;
    public float cameraInputY;

    public float verticalInput;
    public float horizontalInput;


    private void OnEnable()
    {
        if(playerControls == null)
        {
            playerControls = new PlayerMOvement();
            playerControls.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
            playerControls.PlayerMovement.Camera.performed += i => cameraInput = i.ReadValue<Vector2>();
        }
        playerControls.Enable();

    }
    private void OnDisable()
    {
        playerControls.Disable();
    }

    public void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;

        cameraInputY = cameraInput.y;
        cameraInputX = cameraInput.x;

        moveAmount = Mathf.Clamp01(Mathf.Abs(horizontalInput) + Mathf.Abs(verticalInput));
        animManager.UpdateAnimatorValues(0, moveAmount);
    }

    public void HandleAllInputs()
    {
        HandleMovementInput();
    }
}
