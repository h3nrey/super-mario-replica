using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] internal PlayerBehaviour _player;
  	[SerializeField] float normalSpeed, sprintSpeed, startingSpeed;
	[SerializeField] private float speed;
	[Range(1,5)] [SerializeField] float speedIncrement;
	[SerializeField] internal bool running = false, walking = false;

    private void Update() {
		if (_player._input.playerInput.x > 0.1 || _player._input.playerInput.x < -0.1) {
			walk();
		}
		if (walking == false && running == false) {
			speed = startingSpeed;
		}
	}
    void FixedUpdate() {		
		_player.rb.velocity = new Vector2(_player._input.playerInput.x * speed * Time.deltaTime, _player.rb.velocity.y);
    }

    internal void Sprint() {
		running = true;
		if(speed <= sprintSpeed) {
			speed+= speedIncrement;
		}
    }

	internal void walk() {
		walking = true;
		if (speed <= normalSpeed) {
			speed += speedIncrement;
		}
	}

	internal void stopPlayer() {
		walking = false;
	}

   internal void CancelSprint() {
		while(speed > normalSpeed) {
			speed -= speedIncrement;

			if (speed == normalSpeed) break;
        }
		running = false;
   }
}
