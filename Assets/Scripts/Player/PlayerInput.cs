using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
	[SerializeField] internal PlayerBehaviour _playerBehaviour;
	internal Vector2 playerInput;
	[SerializeField] float rotateAmount;
	float rot;

    void Update() {
        playerInput.x = Input.GetAxisRaw("Horizontal");
        
		// if(playerInput.x > 0.1f) {
			// //_playerBehaviour.playerSprite.flipX = false;
			// this.transform.Rotate(Vector3.up * 0, Space.World);
		// }
		// else if(playerInput.x < -0.1f) {
			// // _playerBehaviour.playerSprite.flipX = true;
			// this.transform.Rotate(Vector3.up * 180, Space.World);
		// } 
		
		if (playerInput.x > 0.1f) {
			transform.localRotation = Quaternion.Euler (0f, 0f, 0f);
        } else if(playerInput.x < -0.1f)  {
			transform.localRotation = Quaternion.Euler (0f, rotateAmount, 0f);
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
		
		//Damping
		if(Input.GetButtonUp("Horizontal")) {
			_playerBehaviour._damping.CheckVelocity(_playerBehaviour.rb.velocity.x);
		}

		//Crouching
		if(Input.GetButtonDown("Down")) {
			_playerBehaviour._crouch.Crouch();
		}
		if(Input.GetButtonUp("Down")) {
			_playerBehaviour._crouch.Crouch();
		}

		//Fire
		if(Input.GetButtonDown("Fire")){
			StartCoroutine(_playerBehaviour._powerups.InstantiateFire());
		}

    }
}
