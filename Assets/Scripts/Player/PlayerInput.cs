using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
	[SerializeField] internal PlayerBehaviour _playerBehaviour;
	internal Vector2 playerInput;

    void Update() {
        playerInput.x = Input.GetAxisRaw("Horizontal");
        
		if(playerInput.x > 0.1f) {
			_playerBehaviour.playerSprite.flipX = false;
		}
		else if(playerInput.x < -0.1f) {
			_playerBehaviour.playerSprite.flipX = true;
		} 

		_playerBehaviour._animation.SetAnimationFloat(_playerBehaviour._animation.speedParam, Mathf.Abs(playerInput.x));
		
		//Jump
		if(Input.GetButtonDown("Jump"))	
			_playerBehaviour._jump.Jump();		

		if(Input.GetButton("Jump"))
			_playerBehaviour._jump.Jump();

		if(Input.GetButtonUp("Jump"))	
			_playerBehaviour._jump.StoppingJumping();


		//Sprint
		if(Input.GetButton("Sprint")) {
			_playerBehaviour._movement.Sprint();
		}
		if(Input.GetButtonUp("Sprint")) {
			_playerBehaviour._movement.CancelSprint();
		}

		//Crouching
		if(Input.GetButtonDown("Down")) {
			_playerBehaviour._crouch.Crouch();
		}
		if(Input.GetButtonUp("Down")) {
			_playerBehaviour._crouch.Crouch();
		}

    }
}
