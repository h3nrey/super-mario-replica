using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
	[SerializeField] internal PlayerBehaviour _playerBehaviour;
	internal Vector2 playerInput;

    void Update() {
        playerInput.x = Input.GetAxis("Horizontal");
        
	if(Input.GetButtonDown("Jump")) {	
	_playerBehaviour._jump.Jump();	
             }
	if(Input.GetButton("Sprint")) {
		_playerBehaviour._movement.Sprint();
	}
	if(Input.GetButtonUp("Sprint")) {
		_playerBehaviour._movement.CancelSprint();
	}
	if(Input.GetButtonDown("Down")) {
		_playerBehaviour._crouch.Crouch();
	}
	if(Input.GetButtonUp("Down")) {
		_playerBehaviour._crouch.Crouch();
	}

    }
}
