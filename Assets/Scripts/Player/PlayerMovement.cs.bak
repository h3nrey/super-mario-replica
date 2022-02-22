using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] internal PlayerBehaviour _playerBehaviour;
  	[SerializeField] float normalSpeed, speed, sprintSpeed; 
	[Range(1,5)] [SerializeField] float speedIncrement;
	internal bool running = false;

    void Start() {
    }

    // Update is called once per frame
    void FixedUpdate() {
		if(!running) {
			speed = normalSpeed;
		}
		_playerBehaviour.rb.velocity = new Vector2(_playerBehaviour._input.playerInput.x * speed * Time.deltaTime, _playerBehaviour.rb.velocity.y);
    }

    internal void Sprint() {
		running = true;
		if(speed <= sprintSpeed) {
			speed+= speedIncrement;
		}
    }

   internal void CancelSprint() {
		running = false;
   }
}
