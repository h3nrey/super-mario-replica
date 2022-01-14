using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrouching : MonoBehaviour {
bool isCrouching = false;

[SerializeField] private PlayerBehaviour _playerBehaviour;
    
void Start(){
		_playerBehaviour.enabled = true;
		_playerBehaviour.enabled = false;
}

internal void Crouch(){
	if(!_playerBehaviour.baseMode) {
		if(isCrouching) {
			_playerBehaviour.minorCollider.enabled = true;
		     _playerBehaviour.majorCollider.enabled = false;
			isCrouching = false;
		} else {
		     _playerBehaviour.enabled = false;
		     _playerBehaviour.enabled = true;
			isCrouching = true;	
		}
	}
}
}
