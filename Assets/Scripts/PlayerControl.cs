using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour {
    [SerializeField]
    private Hand rightHand;
    private Hand leftHand;

    public void MoveRight(InputAction.CallbackContext ctx) {
        rightHand.SetDirection(ctx.ReadValue<Vector2>().normalized);
    }

    public void MoveLeft(InputAction.CallbackContext ctx) {
        leftHand.SetDirection(ctx.ReadValue<Vector2>().normalized);
    }

    public void GrabRight(InputAction.CallbackContext ctx) {
    }
}