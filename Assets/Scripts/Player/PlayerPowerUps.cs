using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerUps : MonoBehaviour {
 internal bool onMushroomMode, onFlowerMode, onStarMode;

 [SerializeField] private PlayerBehaviour _playerBehaviour;

    internal void GivePowerUps(string powerupName){
	_playerBehaviour.baseMode = false;

	switch(powerupName){
		case "mushroom":
			ActiveMushroom();
			break;
		case "flower":
			//flower method
			break;
		case "star":
			//star coroutine
			break;
		default:
			//mushroom method
			break;
	}
    }

    internal void ActiveMushroom(){
	onMushroomMode = true;
     _playerBehaviour.majorCollider.enabled = true;
     _playerBehaviour._jump.setupJumpForce(_playerBehaviour._jump.highJumpForce);
	
    }
}
