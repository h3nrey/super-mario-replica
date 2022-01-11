using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
	[SerializeField] internal PlayerBehaviour _playerBehaviour;
	internal Vector2 playerInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update() {
        playerInput.x = Input.GetAxisRaw("Horizontal");
        
	if(Input.GetButtonDown("Jump")) {	
	_playerBehaviour._jump.Jump();	
             }
	if(Input.GetButton("Sprint")) {
		_playerBehaviour._movement.Sprint();
	}
	if(Input.GetButtonUp("Sprint")) {
		_playerBehaviour._movement.CancelSprint();
	}
    }
}
