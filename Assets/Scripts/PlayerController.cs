using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // [SerializeField] PlayerMovement _playerMovementScript;
    public PlayerMovement _playerMovementScript;


    public void JumpCharacter(InputAction.CallbackContext ctx)
    {
        _playerMovementScript.Jump();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
