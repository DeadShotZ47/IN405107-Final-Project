using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class GatherInput : MonoBehaviour
{

    public Control controls;
    public float valueX = 0;
    public bool jumpInput;
    public bool tryAttack;

    public void Awake()
    {
        controls = new Control();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        controls.Player.Move.performed += StartMove;
        controls.Player.Move.canceled += StopMove;
        controls.Player.Jump.performed += JumpStart;
        controls.Player.Jump.canceled += JumpStop;
        controls.Player.Enable();
    }

    public void OnDisable()
    {
        controls.Player.Move.performed -= StartMove;
        controls.Player.Move.canceled -= StopMove;
        controls.Player.Jump.performed -= JumpStart;
        controls.Player.Jump.canceled -= JumpStop;
        controls.Player.Disable();
    }

    public void DisableControls()
    {
        controls.Player.Move.performed -= StartMove;
        controls.Player.Move.canceled -= StopMove;
        controls.Player.Jump.performed -= JumpStart;
        controls.Player.Jump.canceled -= JumpStop;
        controls.Player.Disable();
        valueX = 0;
    }

    private void StartMove(InputAction.CallbackContext ctx) 
    {
        valueX = ctx.ReadValue<float>();
    }

    private void StopMove(InputAction.CallbackContext ctx)
    {
        valueX = 0;
    }

    private void JumpStart(InputAction.CallbackContext ctx) 
    {
        jumpInput = true;
    }

    private void JumpStop(InputAction.CallbackContext ctx)
    {
        jumpInput = false;
    }
}
