using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    private Hand maindroite;
    public void MoveRight(InputAction.CallbackContext ctx){

        maindroite.SetDirection(ctx.ReadValue<Vector2>().normalized);
        
    }
}